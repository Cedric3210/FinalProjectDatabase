using Consultation.BackEndCRUD.Repository.IRepository;
using Consultation.BackEndCRUD.Repository;
using Consultation.BackEndCRUD.Service.IService;
using Consultation.BackEndCRUD.ViewModel.ConsultationViewModel;
using Consultation.Domain.Enum;
using Consultation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.BackEndCRUD.Service
{
    public class EditConsultationService : IEditConsultationService
    {
       
        private readonly IEditConsultationrequestRepository _editRepo;

        public EditConsultationService(AppDbContext appDbContext)
        {
           _editRepo = new EditConsultationrequestRepository(appDbContext);

        }
        public async Task<EditConsultationViewModel> getEditConsultation(int studentID)
        {
            var editConsultation = await _editRepo.GetConsultationRequests(studentID);

            return new EditConsultationViewModel
            {
                studentName = editConsultation.Student.StudentName,
                courseCode = editConsultation.SubjectCode,
                studentUMID = editConsultation.Student.StudentUMID,
                concernDescription = editConsultation.Concern,
                dateSchedule = editConsultation.DateSchedule,
                startedTime = editConsultation.StartedTime,
                Status = editConsultation.Status
            };
        }
    }
}
