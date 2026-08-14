using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003AC8")]
public class TaskAutoWithSpriteAnim : TaskAuto
{
	[Token(Token = "0x4018FA2")]
	[FieldOffset(Offset = "0x64")]
	public UISprite[] AnimSprite;

	[Token(Token = "0x6017470")]
	[Address(RVA = "0x28955EC", Offset = "0x28955EC", VA = "0x28955EC")]
	public TaskAutoWithSpriteAnim()
	{
	}

	[Token(Token = "0x6017471")]
	[Address(RVA = "0x2895600", Offset = "0x2895600", VA = "0x2895600", Slot = "4")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x6017472")]
	[Address(RVA = "0x28956CC", Offset = "0x28956CC", VA = "0x28956CC", Slot = "10")]
	protected override void OnProgressUpdate(float progress)
	{
	}

	[Token(Token = "0x6017473")]
	[Address(RVA = "0x28957A4", Offset = "0x28957A4", VA = "0x28957A4")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6017474")]
	[Address(RVA = "0x28957A8", Offset = "0x28957A8", VA = "0x28957A8")]
	public void _003C_003EiFixBaseProxy_OnProgressUpdate(float P0)
	{
	}
}
