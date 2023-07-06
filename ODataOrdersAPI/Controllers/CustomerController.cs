namespace ODataOrdersAPI.Controllers;

public class CustomerController : ODataController
{
    private readonly AppDbContext context;
    public CustomerController(AppDbContext context)
    {
        this.context = context;
    }


    [EnableQuery]
    public IActionResult Get()
    {
        return Ok(context.Customers);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Customer newCustomer)
    {
        context.Customers.Add(newCustomer);
        await context.SaveChangesAsync();

        return Created("url", newCustomer);
    }
}