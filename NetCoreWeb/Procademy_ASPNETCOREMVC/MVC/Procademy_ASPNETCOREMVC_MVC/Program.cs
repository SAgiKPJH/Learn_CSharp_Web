var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); // Controller ���̻縦 Ž���Ͽ� ��� - ��) HomeController
var app = builder.Build();

//app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//    app.MapControllers(); // ��� ��Ʈ�ѷ��� �۾� �޼��带 ���� �� Route �ڵ��߰�
//});
app.MapControllers(); // �� �ּ� ��ſ� ��� ����
// �ڵ����� UseRouting() ȣ�� �� ���Ŀ��� EndPoint�� ���

app.Run();