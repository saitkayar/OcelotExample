﻿using ContactAPI.Infrastructure;
using ContactAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]
        public ContactDTO  Get(int id) {
        
        return contactService.GetContactById(id);
        }
    }
}
