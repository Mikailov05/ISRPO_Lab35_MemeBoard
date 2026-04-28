using Microsoft.AspNetCore.Mvc;
using MemesApi.Models;
using MemesApi.data;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MemesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MemesController : ControllerBase {


    [HttpGet]
    public ActionResult<List<Meme>> GetAll() {
        return Ok(MemesStore.Memes);

    }

    public ActionResult<Meme> GetById(int id) {
        var meme = MemesStore.Memes.FirstOrDefault(m => m.Id == id);
        if (meme is null) {
            return NotFound(new { message = $"Мем с id ={id} не найден" });
        }
        return Ok(meme);
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(int id) {
        var meme = MemesStore.Memes.FirstOrDefault(m => m.Id == id);
        if (meme is null) {
            return NotFound(new { message = "$Мем с id = {id} не найден" });

        }
        MemesStore.Memes.Remove(meme);
        return NotContent();
        
    }

    private ActionResult NotContent() {
        throw new NotImplementedException();
    }
}
