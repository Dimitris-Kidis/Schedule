using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Users.DeleteUserById
{
    public class DeleteUserByIdCommand : IRequest
    {
        //[FromRoute(Name = "id")]
        public int Id { get; set; }
    }
}
