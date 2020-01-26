using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using GamePortalMVC.Data;
using GamePortalMVC.Data.Repositories;
using GamePortalMVC.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace GamePortalMVC.Data
{
    public class ServiceInitialize
    {
        public DbAuthContext _context;
        
        public ServiceInitialize(DbAuthContext context)
        {
            _context = context;
        }
    }
    
}
