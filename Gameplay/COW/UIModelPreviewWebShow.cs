using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20031D7")]
public class UIModelPreviewWebShow : UIBaseModel
{
	[Token(Token = "0x4012F8C")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, PreviewWebDesc> m_PreviewWebDescDic;

	[Token(Token = "0x6015082")]
	[Address(RVA = "0x31314E0", Offset = "0x31314E0", VA = "0x31314E0")]
	public UIModelPreviewWebShow()
	{
	}

	[Token(Token = "0x6015083")]
	[Address(RVA = "0x3131598", Offset = "0x3131598", VA = "0x3131598", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6015084")]
	[Address(RVA = "0x3131678", Offset = "0x3131678", VA = "0x3131678", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015085")]
	[Address(RVA = "0x31316D0", Offset = "0x31316D0", VA = "0x31316D0")]
	public void ProcessCSGetPreviewWebDescRes(CSGetPreviewWebDescRes res)
	{
	}

	[Token(Token = "0x6015086")]
	[Address(RVA = "0x31319D4", Offset = "0x31319D4", VA = "0x31319D4")]
	public bool NeedShowGuide(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6015087")]
	[Address(RVA = "0x3131AA0", Offset = "0x3131AA0", VA = "0x3131AA0")]
	public PreviewWebDesc GetShowDescByID(uint itemID)
	{
		return null;
	}

	[Token(Token = "0x6015088")]
	[Address(RVA = "0x3131B88", Offset = "0x3131B88", VA = "0x3131B88")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
