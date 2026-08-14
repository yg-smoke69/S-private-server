using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022BD")]
internal class UIHUDPVEMissionItemController : UIBaseController
{
	[Token(Token = "0x400D935")]
	[FieldOffset(Offset = "0x28")]
	public HUDPVEMissionItemView m_View;

	[Token(Token = "0x600BF1C")]
	[Address(RVA = "0x16841AC", Offset = "0x16841AC", VA = "0x16841AC")]
	public UIHUDPVEMissionItemController()
	{
	}

	[Token(Token = "0x600BF1D")]
	[Address(RVA = "0x1684230", Offset = "0x1684230", VA = "0x1684230")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF1E")]
	[Address(RVA = "0x16842D8", Offset = "0x16842D8", VA = "0x16842D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF1F")]
	[Address(RVA = "0x1684394", Offset = "0x1684394", VA = "0x1684394")]
	public void OnDataCome(string content)
	{
	}

	[Token(Token = "0x600BF20")]
	[Address(RVA = "0x168442C", Offset = "0x168442C", VA = "0x168442C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
