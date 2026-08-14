using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002268")]
public class AirLineObject
{
	[Token(Token = "0x400D723")]
	[FieldOffset(Offset = "0x8")]
	private UISprite m_AirLine;

	[Token(Token = "0x400D724")]
	[FieldOffset(Offset = "0xC")]
	private UISprite m_AirLineStart;

	[Token(Token = "0x400D725")]
	[FieldOffset(Offset = "0x10")]
	private UISprite m_AirLineEnd;

	[Token(Token = "0x400D726")]
	[FieldOffset(Offset = "0x14")]
	private bool m_AirLineVisible;

	[Token(Token = "0x400D727")]
	[FieldOffset(Offset = "0x15")]
	private bool m_FadeLine;

	[Token(Token = "0x400D728")]
	[FieldOffset(Offset = "0x18")]
	private float m_Scale;

	[Token(Token = "0x600BBF1")]
	[Address(RVA = "0x14C3520", Offset = "0x14C3520", VA = "0x14C3520")]
	public AirLineObject()
	{
	}

	[Token(Token = "0x600BBF2")]
	[Address(RVA = "0x14C3528", Offset = "0x14C3528", VA = "0x14C3528")]
	public void SetAirLineSprites(UISprite line, UISprite start, UISprite end, float scale, bool fadeLine)
	{
	}

	[Token(Token = "0x600BBF3")]
	[Address(RVA = "0x14C3FE0", Offset = "0x14C3FE0", VA = "0x14C3FE0")]
	public void Update()
	{
	}

	[Token(Token = "0x600BBF4")]
	[Address(RVA = "0x14C35F0", Offset = "0x14C35F0", VA = "0x14C35F0")]
	private void SetupAirLine()
	{
	}

	[Token(Token = "0x600BBF5")]
	[Address(RVA = "0x14C4140", Offset = "0x14C4140", VA = "0x14C4140")]
	private void ShowAirLine()
	{
	}

	[Token(Token = "0x600BBF6")]
	[Address(RVA = "0x14C3ED0", Offset = "0x14C3ED0", VA = "0x14C3ED0")]
	private void HideAirLine()
	{
	}

	[Token(Token = "0x600BBF7")]
	[Address(RVA = "0x14C42F0", Offset = "0x14C42F0", VA = "0x14C42F0")]
	private void SetAirLineAlpha(float alpha)
	{
	}

	[Token(Token = "0x600BBF8")]
	[Address(RVA = "0x14C41C4", Offset = "0x14C41C4", VA = "0x14C41C4")]
	private void SetAirLineActive(bool active)
	{
	}
}
