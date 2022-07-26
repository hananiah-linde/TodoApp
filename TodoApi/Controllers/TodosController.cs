﻿using Microsoft.AspNetCore.Mvc;
using TodoLibrary.Models;

namespace TodoApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TodosController : ControllerBase
{
    // GET: api/<TodosController>
    [HttpGet]
    public ActionResult<IEnumerable<Todo>> Get()
    {
        throw new NotImplementedException();
    }

    // GET api/todos/5
    [HttpGet("{id}")]
    public ActionResult<Todo> Get(int id)
    {
        throw new NotImplementedException();
    }

    // POST api/todos
    [HttpPost]
    public IActionResult Post([FromBody] string value)
    {
        throw new NotImplementedException();
    }

    // PUT api/todos/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] string value)
    {
        throw new NotImplementedException();
    }

    // PUT api/todos/5/complete
    [HttpPut("{id}/complete")]
    public IActionResult Complete(int id)
    {
        throw new NotImplementedException();
    }

    // DELETE api/todos/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        throw new NotImplementedException();
    }
}
