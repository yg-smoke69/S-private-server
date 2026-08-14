using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200248E")]
internal class UGCInfectionChangePanelController : UIBaseController
{
	[Token(Token = "0x400E2A4")]
	[FieldOffset(Offset = "0x28")]
	private UGCInfectionChangePanelView m_View;

	[Token(Token = "0x400E2A5")]
	[FieldOffset(Offset = "0x2C")]
	private int m_CountdownNumber;

	[Token(Token = "0x400E2A6")]
	[FieldOffset(Offset = "0x30")]
	private float m_Countdown;

	[Token(Token = "0x400E2A7")]
	[FieldOffset(Offset = "0x34")]
	private uint m_SelectedID;

	[Token(Token = "0x400E2A8")]
	[FieldOffset(Offset = "0x38")]
	private List<UGCInfectionChangeItemController> m_ItemControllers;

	[Token(Token = "0x400E2A9")]
	private const string ChooseRole = "T_35_PD_Infection_ZOMBIESELECT";

	[Token(Token = "0x400E2AA")]
	private const string ChooseWeapon = "T_35_PD_Infection_HUMANSELECT";

	[Token(Token = "0x600D0C9")]
	[Address(RVA = "0x29F1C44", Offset = "0x29F1C44", VA = "0x29F1C44")]
	public UGCInfectionChangePanelController()
	{
	}

	[Token(Token = "0x600D0CA")]
	[Address(RVA = "0x29F1CFC", Offset = "0x29F1CFC", VA = "0x29F1CFC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D0CB")]
	[Address(RVA = "0x29F1DA4", Offset = "0x29F1DA4", VA = "0x29F1DA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D0CC")]
	[Address(RVA = "0x29F1EAC", Offset = "0x29F1EAC", VA = "0x29F1EAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600D0CD")]
	[Address(RVA = "0x29F2048", Offset = "0x29F2048", VA = "0x29F2048")]
	public void SetViewData(PNJCBPMOLMJ info)
	{
	}

	[Token(Token = "0x600D0CE")]
	[Address(RVA = "0x29F26AC", Offset = "0x29F26AC", VA = "0x29F26AC")]
	private void OnSelectedUpdate(object[] data)
	{
	}

	[Token(Token = "0x600D0CF")]
	[Address(RVA = "0x29F2878", Offset = "0x29F2878", VA = "0x29F2878")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
