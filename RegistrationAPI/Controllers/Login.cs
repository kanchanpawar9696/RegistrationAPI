using AutoMapper;
using ClassAPI.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationAPI.IREPO;

namespace RegistrationAPI.Controllers
{
    [Route("api/Login")]
    [ApiController]
    public class Login : ControllerBase
    {

        private readonly IRepoLoginModel _repo;
        private readonly IMapper _mapper;
        public Login(IRepoLoginModel repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }
        [HttpGet]
     //  [Route("get-data")]
        public async Task<IActionResult>LoginAlls()
        {
            var add = await _repo.LoginAll();
            var addto = _mapper.Map<List<LoginModel>>(add);
            return Ok(addto);

        }


        [HttpGet("Id")]
       // [Route("id")]
        public async Task<IActionResult>GetLogin(int id)
        {
            var add = await _repo.GetLogin(id);
            var addto = _mapper.Map<LoginModel>(add);
            return Ok(addto);
        }


        [HttpPost("Add")]
      // [Route("ADD")]
        public async Task<IActionResult>AddLogin(LoginModel login)
        {

            var add = new ClassAPI.MODEL.LoginModel()
            {
                srno = login.srno,
                userid = login.userid,
                password = login.password,
                custname = login.custname,
                address = login.address,
                salary = login.salary,
                emailid = login.emailid,


            };
            add = await _repo.AddLogin(add);
            var addto = new LoginModel()
            {
                srno = add.srno,
                userid = add.userid,
                password = add.password,
                custname = add.custname,
                address = add.address,
                salary = add.salary,
                emailid = add.emailid,

            };
            return Ok(addto);
            }

        [HttpPut("UPDATE/ID")]
       // [Route("UPDATE/ID")]
        public async Task<IActionResult> UPDATELOGIN(int id,LoginModel login)
        {

            var add = new ClassAPI.MODEL.LoginModel()
            {
                srno = login.srno,
                userid = login.userid,
                password = login.password,
                custname = login.custname,
                address = login.address,
                salary = login.salary,
                emailid = login.emailid,


            };
            add = await _repo.UpdateLogin(id,add);
            if (add == null)
            {
                return NotFound();

            }

            var addto = new LoginModel()
            {
                srno = add.srno,
                userid = add.userid,
                password = add.password,
                custname = add.custname,
                address = add.address,
                salary = add.salary,
                emailid = add.emailid,


            };
            return Ok(addto);
        }


        [HttpDelete("DELETE/ID")]
        public async Task<IActionResult> DELETELOGIN(int id)
        {
            var add = new ClassAPI.MODEL.LoginModel();
            if (add == null)
            {
                return NotFound();

            }

            add = await _repo.DeleteLogin(id);
            var addto = new LoginModel()

            {
                srno = add.srno,
                userid = add.userid,
                password = add.password,
                custname=add.custname,
                address = add.address,
                salary = add.salary,
                emailid = add.emailid,

            };
            return Ok(addto);
        }


    }
}
