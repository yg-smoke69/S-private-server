using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001604")]
public class CSGetRecommendedStudentListRes
{
	[Token(Token = "0x40094D0")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasicBundleRes rand_student_list;

	[Token(Token = "0x6007C4E")]
	[Address(RVA = "0x3095204", Offset = "0x3095204", VA = "0x3095204")]
	public CSGetRecommendedStudentListRes()
	{
	}
}
