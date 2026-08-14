using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002898")]
internal class UIHUDUGC_ZombieLevelController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002899")]
	private sealed class _003CSetCurrentLevel_003Ec__AnonStorey1
	{
		[Token(Token = "0x400FA00")]
		[FieldOffset(Offset = "0x8")]
		internal int cur;

		[Token(Token = "0x600FEF1")]
		[Address(RVA = "0x2932BBC", Offset = "0x2932BBC", VA = "0x2932BBC")]
		public _003CSetCurrentLevel_003Ec__AnonStorey1()
		{
		}
	}

	[Token(Token = "0x200289A")]
	private sealed class _003CSetCurrentLevel_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FA01")]
		[FieldOffset(Offset = "0x8")]
		internal int identity;

		[Token(Token = "0x400FA02")]
		[FieldOffset(Offset = "0xC")]
		internal _003CSetCurrentLevel_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

		[Token(Token = "0x600FEF2")]
		[Address(RVA = "0x2932BC4", Offset = "0x2932BC4", VA = "0x2932BC4")]
		public _003CSetCurrentLevel_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600FEF3")]
		[Address(RVA = "0x2932E98", Offset = "0x2932E98", VA = "0x2932E98")]
		internal bool _003C_003Em__0(InfectionZombieGrowUpData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400F9F8")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_ZombieLevelView m_View;

	[Token(Token = "0x400F9F9")]
	[FieldOffset(Offset = "0x2C")]
	private ZombieLevelHudEntity m_ViewData;

	[Token(Token = "0x400F9FA")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x400F9FB")]
	[FieldOffset(Offset = "0x34")]
	private List<UIHUDUGC_ZombieLevelItemController> m_ItemList;

	[Token(Token = "0x400F9FC")]
	[FieldOffset(Offset = "0x38")]
	private bool m_LongPressed;

	[Token(Token = "0x400F9FD")]
	[FieldOffset(Offset = "0x3C")]
	private int m_SpeedUp;

	[Token(Token = "0x400F9FE")]
	[FieldOffset(Offset = "0x40")]
	private int m_JumpUp;

	[Token(Token = "0x400F9FF")]
	[FieldOffset(Offset = "0x44")]
	private List<InfectionZombieGrowUpData> m_DataList;

	[Token(Token = "0x600FEE6")]
	[Address(RVA = "0x29314FC", Offset = "0x29314FC", VA = "0x29314FC")]
	public UIHUDUGC_ZombieLevelController()
	{
	}

	[Token(Token = "0x600FEE7")]
	[Address(RVA = "0x29315E8", Offset = "0x29315E8", VA = "0x29315E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FEE8")]
	[Address(RVA = "0x2931690", Offset = "0x2931690", VA = "0x2931690", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FEE9")]
	[Address(RVA = "0x2931B48", Offset = "0x2931B48", VA = "0x2931B48", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600FEEA")]
	[Address(RVA = "0x2931D20", Offset = "0x2931D20", VA = "0x2931D20", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600FEEB")]
	[Address(RVA = "0x2931D94", Offset = "0x2931D94", VA = "0x2931D94")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600FEEC")]
	[Address(RVA = "0x29321A4", Offset = "0x29321A4", VA = "0x29321A4")]
	private void SetTotalLevel(int old, int cur)
	{
	}

	[Token(Token = "0x600FEED")]
	[Address(RVA = "0x293269C", Offset = "0x293269C", VA = "0x293269C")]
	private void SetCurrentLevel(int old, int cur)
	{
	}

	[Token(Token = "0x600FEEE")]
	[Address(RVA = "0x2932BCC", Offset = "0x2932BCC", VA = "0x2932BCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600FEEF")]
	[Address(RVA = "0x2932E88", Offset = "0x2932E88", VA = "0x2932E88")]
	private void _003COnUIInit_003Em__0(bool press)
	{
	}

	[Token(Token = "0x600FEF0")]
	[Address(RVA = "0x2932E90", Offset = "0x2932E90", VA = "0x2932E90")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
