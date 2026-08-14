using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E6A")]
public class AutoTaskRecommendFriend : AutoPopupTask
{
	[Token(Token = "0x6009221")]
	[Address(RVA = "0x10F92E8", Offset = "0x10F92E8", VA = "0x10F92E8")]
	public AutoTaskRecommendFriend()
	{
	}

	[Token(Token = "0x6009222")]
	[Address(RVA = "0x10F92F0", Offset = "0x10F92F0", VA = "0x10F92F0", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009223")]
	[Address(RVA = "0x10F945C", Offset = "0x10F945C", VA = "0x10F945C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6009224")]
	[Address(RVA = "0x10F94B4", Offset = "0x10F94B4", VA = "0x10F94B4", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
