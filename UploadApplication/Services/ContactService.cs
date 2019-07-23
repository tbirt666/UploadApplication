using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UploadApplication.Models;

namespace UploadApplication.Services
{
    public class ContactService : IContactService
    {
        public void Import(ContactImport importFile)
        {
            // todo: process file
            //      validate/sanitise file

            // for each contact 
                   //dedupe against DB 
                   // upsert 
            

            // todo: method should return status/error result but left void for now
        }
    }
}