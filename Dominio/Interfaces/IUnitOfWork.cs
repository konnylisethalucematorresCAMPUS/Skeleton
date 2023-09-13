namespace Dominio.Interfaces;

    public interface IUnitOfWork
    {
        
        //Aqui van los metodos y las interfaces
         
        Task<int> SaveAsync();
    }
