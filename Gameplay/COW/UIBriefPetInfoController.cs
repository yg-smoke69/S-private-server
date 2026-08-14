using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002500")]
internal class UIBriefPetInfoController : UIBaseController
{
	[Token(Token = "0x400E5CC")]
	[FieldOffset(Offset = "0x28")]
	private UIBriefProfileInfoView m_View;

	[Token(Token = "0x600D650")]
	[Address(RVA = "0x1444BCC", Offset = "0x1444BCC", VA = "0x1444BCC")]
	public UIBriefPetInfoController()
	{
	}

	[Token(Token = "0x600D651")]
	[Address(RVA = "0x1444C50", Offset = "0x1444C50", VA = "0x1444C50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D652")]
	[Address(RVA = "0x1444CF4", Offset = "0x1444CF4", VA = "0x1444CF4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D653")]
	[Address(RVA = "0x1444DB0", Offset = "0x1444DB0", VA = "0x1444DB0")]
	public void SetNickName(string nickname, uint pet_id, uint lv)
	{
	}

	[Token(Token = "0x600D654")]
	[Address(RVA = "0x144520C", Offset = "0x144520C", VA = "0x144520C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
