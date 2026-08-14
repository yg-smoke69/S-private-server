using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B06")]
internal class UISceneEditGMVerifyController : UIBaseController, _Attribute
{
	[Token(Token = "0x6011AB7")]
	[Address(RVA = "0x14ACE90", Offset = "0x14ACE90", VA = "0x14ACE90")]
	public UISceneEditGMVerifyController()
	{
	}

	[Token(Token = "0x6011AB8")]
	[Address(RVA = "0x14ACF14", Offset = "0x14ACF14", VA = "0x14ACF14", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011AB9")]
	[Address(RVA = "0x14ACF88", Offset = "0x14ACF88", VA = "0x14ACF88", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}
}
