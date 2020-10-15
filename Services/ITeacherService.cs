using AutoMapper;
using ExamPortal.DTOS;
using ExamPortal.Models;
using ExamPortal.Repositories;
using ExamPortal.Utilities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Services
{
    public interface ITeacherService
    {
        /// <summary>
        /// save paper to database and returns sharable code
        /// </summary>
        public string CreatePaper(MCQPaperDTO paper);
    }

    public class TeacherServiceImpl : ITeacherService
    {
        public TeacherServiceImpl(IMapper mapper, IMCQPaperRepo paperRepo, SignInManager<IdentityUser> signInManager)
        {
            Mapper = mapper;
            PaperRepo = paperRepo;
            SignInManager = signInManager;
        }

        public IMapper Mapper { get; }
        public IMCQPaperRepo PaperRepo { get; }
        public SignInManager<IdentityUser> SignInManager { get; }

        public string CreatePaper(MCQPaperDTO paper)
        {
            string code = CodeGenerator.GetSharableCode();
            MCQPaper mcqPaper = Mapper.Map<MCQPaperDTO, MCQPaper>(paper);
            mcqPaper.PaperCode = code;
            foreach (var que in paper.Questions)
                mcqPaper.Questions.Add(que.DtoTOEntity());
            PaperRepo.Create(mcqPaper);
            return code;
        }
    }
}
