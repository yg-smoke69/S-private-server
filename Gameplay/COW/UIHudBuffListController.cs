using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026F8")]
internal class UIHudBuffListController : UIBaseController
{
	[Token(Token = "0x20026F9")]
	private sealed class _003COnBuffBehaviorChanged_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F09E")]
		[FieldOffset(Offset = "0x8")]
		internal CBIKNJDAGLO bevData;

		[Token(Token = "0x600EC90")]
		[Address(RVA = "0x1E18D20", Offset = "0x1E18D20", VA = "0x1E18D20")]
		public _003COnBuffBehaviorChanged_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600EC91")]
		[Address(RVA = "0x1E1966C", Offset = "0x1E1966C", VA = "0x1E1966C")]
		internal bool _003C_003Em__0(CBIKNJDAGLO temp)
		{
			return default(bool);
		}

		[Token(Token = "0x600EC92")]
		[Address(RVA = "0x1E196B8", Offset = "0x1E196B8", VA = "0x1E196B8")]
		internal bool _003C_003Em__1(CBIKNJDAGLO temp)
		{
			return default(bool);
		}

		[Token(Token = "0x600EC93")]
		[Address(RVA = "0x1E19704", Offset = "0x1E19704", VA = "0x1E19704")]
		internal bool _003C_003Em__2(CBIKNJDAGLO temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400F09B")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBuffListView m_View;

	[Token(Token = "0x400F09C")]
	[FieldOffset(Offset = "0x2C")]
	private List<CBIKNJDAGLO> m_CurrentBuffBehaivorList;

	[Token(Token = "0x400F09D")]
	[FieldOffset(Offset = "0x30")]
	private List<UIHudBuffListItemController> m_ItemControllers;

	[Token(Token = "0x600EC86")]
	[Address(RVA = "0x1E18298", Offset = "0x1E18298", VA = "0x1E18298")]
	public UIHudBuffListController()
	{
	}

	[Token(Token = "0x600EC87")]
	[Address(RVA = "0x1E1831C", Offset = "0x1E1831C", VA = "0x1E1831C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EC88")]
	[Address(RVA = "0x1E183C0", Offset = "0x1E183C0", VA = "0x1E183C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EC89")]
	[Address(RVA = "0x1E185A4", Offset = "0x1E185A4", VA = "0x1E185A4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EC8A")]
	[Address(RVA = "0x1E18608", Offset = "0x1E18608", VA = "0x1E18608")]
	protected void OnBuffBehaviorChanged(object[] param)
	{
	}

	[Token(Token = "0x600EC8B")]
	[Address(RVA = "0x1E193FC", Offset = "0x1E193FC", VA = "0x1E193FC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EC8C")]
	[Address(RVA = "0x1E18D28", Offset = "0x1E18D28", VA = "0x1E18D28")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600EC8D")]
	[Address(RVA = "0x1E19654", Offset = "0x1E19654", VA = "0x1E19654")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EC8E")]
	[Address(RVA = "0x1E1965C", Offset = "0x1E1965C", VA = "0x1E1965C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600EC8F")]
	[Address(RVA = "0x1E19664", Offset = "0x1E19664", VA = "0x1E19664")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
