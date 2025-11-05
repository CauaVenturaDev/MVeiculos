using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVeiculos.Banco;

public class DAL<T> where T : class
{
    private readonly MVeiculosContext context;

    public DAL(MVeiculosContext context)
    {
        this.context = context;
    }

    public IEnumerable<T> List()
    {
        return context.Set<T>().ToList();
    }
    public void Add(T t)
    {
        context.Set<T>().Add(t);
        context.SaveChanges();
    }
    public void Remove(T t)
    {
        context.Set<T>().Remove(t);
    }
    public void Update(T t)
    {
        context.Set<T>().Update(t);
    }
    public T? SearchBy(Func<T, bool> condition)
    {
        return context.Set<T>().FirstOrDefault(condition);
    }
    public IEnumerable<T> ListBy(Func<T, bool> condition)
    {
        return context.Set<T>().Where(condition);
    }


    
}
