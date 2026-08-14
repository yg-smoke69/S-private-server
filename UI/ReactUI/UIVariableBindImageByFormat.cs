using GCommon;
using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CD2")]
public sealed class UIVariableBindImageByFormat : UIVariableBind
{
	[Token(Token = "0x4006801")]
	[FieldOffset(Offset = "0x0")]
	private static ResourceManager m_Res;

	[Token(Token = "0x4006802")]
	[FieldOffset(Offset = "0x1C")]
	private string format;

	[Token(Token = "0x4006803")]
	[FieldOffset(Offset = "0x20")]
	private string spriteBind;

	[Token(Token = "0x4006804")]
	[FieldOffset(Offset = "0x24")]
	private bool autoFitNativeSize;

	[Token(Token = "0x4006805")]
	[FieldOffset(Offset = "0x25")]
	private bool autoDisable;

	[Token(Token = "0x4006806")]
	[FieldOffset(Offset = "0x26")]
	private bool refreshImageOnInitial;

	[Token(Token = "0x4006807")]
	[FieldOffset(Offset = "0x28")]
	private UISprite m_image;

	[Token(Token = "0x4006808")]
	[FieldOffset(Offset = "0x2C")]
	private UITexture m_rawImage;

	[Token(Token = "0x4006809")]
	[FieldOffset(Offset = "0x30")]
	private UIVariable imageVariable;

	[Token(Token = "0x600616B")]
	[Address(RVA = "0x3163AD4", Offset = "0x3163AD4", VA = "0x3163AD4")]
	public UIVariableBindImageByFormat()
	{
	}

	[Token(Token = "0x600616C")]
	[Address(RVA = "0x3163B60", Offset = "0x3163B60", VA = "0x3163B60", Slot = "6")]
	protected override void BindVariables()
	{
	}

	[Token(Token = "0x600616D")]
	[Address(RVA = "0x3164378", Offset = "0x3164378", VA = "0x3164378", Slot = "7")]
	protected override void UnbindVariables()
	{
	}

	[Token(Token = "0x600616E")]
	[Address(RVA = "0x3163D18", Offset = "0x3163D18", VA = "0x3163D18")]
	private void RefreshImage()
	{
	}

	[Token(Token = "0x600616F")]
	[Address(RVA = "0x3164478", Offset = "0x3164478", VA = "0x3164478")]
	private void RefreshDisableStatus(UISprite img)
	{
	}

	[Token(Token = "0x6006170")]
	[Address(RVA = "0x31645C8", Offset = "0x31645C8", VA = "0x31645C8")]
	private new void Awake()
	{
	}
}
