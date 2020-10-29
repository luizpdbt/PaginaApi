using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaginaApi.Controllers
{
    [ApiController]
    public class FiltraController : ControllerBase
    {


        [Route("paginaDados")]
        [HttpGet]
        public IActionResult PaginarDados(int numero)
        {

            if(numero==null)
            {
                numero = 0;
            }

            var list = new List<object>();

            var p = new
            {
                nome = "1"
            };


            var p2 = new
            {
                nome = "2"
            };


            var p3 = new
            {
                nome = "3"
            };


            var p4 = new
            {
                nome = "4"
            };

            var p5 = new
            {
                nome = "5"
            };


            var p6 = new
            {
                nome = "6"
            };


            var p7 = new
            {
                nome = "7"
            };

            var p8 = new
            {
                nome = "8"
            };

            var p9 = new
            {
                nome = "9"
            };


            list.Add(p);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);
            list.Add(p6);
            list.Add(p7);
            list.Add(p8);
            list.Add(p9);


            var qtRegistro = list.Skip<object>(numero).Take(4).ToList();

            var paginasRealizadas = list.Count/4;
            var resto = list.Count % 4;

            var qtdPagina = new
            {
                qtdRegistros = list.Count,  
            };


            var Registros = new
            {
                Data = qtRegistro
            };

            var EntregaValores = new
            {
                Registros = Registros.Data,
                informacoes = qtdPagina,
                paginasRealizadas = paginasRealizadas+resto
            };


            return Ok(EntregaValores);
        }
    }
}