using DTO;

namespace DataLayer
{
    public interface IStaffDAL
    {
        List<PersonDTO> SelectAllStaffMembers();
        void AddStaff(PersonDTO person);
        void DeleteStaff(PersonDTO staffDTO);
    }
}