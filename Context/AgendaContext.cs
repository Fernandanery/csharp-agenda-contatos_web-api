using Curso_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Curso_API.Context
{
    //Context - Classe que centraliza todas as informações do banco de dados
    public class AgendaContext : DbContext
    {
        //Construtor que conecta a um banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base (options)
        {

        } 
        
        //Propriedade que se refere a entidade (classe no nosso programa e tabela no bd)
        public DbSet <Contato> Contatos {get; set;}
    }
}