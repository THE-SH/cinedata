namespace CineDataAPI.Domain.Validations.Interfaces{
    public interface IValidation<T> where T : class{
        void IsValidToInsert(T entity){

        }
        
        void IsValidToUpdate(T entity){

        }
    }
}