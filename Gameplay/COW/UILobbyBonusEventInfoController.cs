using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x200291D")]
public class UILobbyBonusEventInfoController : UIBaseController
{
	[Token(Token = "0x200291E")]
	private sealed class _003CRefreshBonusEventInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FD39")]
		[FieldOffset(Offset = "0x8")]
		internal MapModeData mapModeData;

		[Token(Token = "0x400FD3A")]
		[FieldOffset(Offset = "0xC")]
		internal HHDIPHFOBFO groupMode;

		[Token(Token = "0x400FD3B")]
		[FieldOffset(Offset = "0x10")]
		internal UILobbyBonusEventInfoController _0024this;

		[Token(Token = "0x60104F7")]
		[Address(RVA = "0x216D330", Offset = "0x216D330", VA = "0x216D330")]
		public _003CRefreshBonusEventInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60104F8")]
		[Address(RVA = "0x216D348", Offset = "0x216D348", VA = "0x216D348")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400FD35")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyBonusEventInfoView m_View;

	[Token(Token = "0x400FD36")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelGameBonusEvent m_ModelGameBonusEvent;

	[Token(Token = "0x400FD37")]
	[FieldOffset(Offset = "0x30")]
	private GameBonusEventDesc m_EventDesc;

	[Token(Token = "0x400FD38")]
	[FieldOffset(Offset = "0x34")]
	private uint m_DelayCall;

	[Token(Token = "0x60104EB")]
	[Address(RVA = "0x216B844", Offset = "0x216B844", VA = "0x216B844")]
	public UILobbyBonusEventInfoController()
	{
	}

	[Token(Token = "0x60104EC")]
	[Address(RVA = "0x216B8C8", Offset = "0x216B8C8", VA = "0x216B8C8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60104ED")]
	[Address(RVA = "0x216B96C", Offset = "0x216B96C", VA = "0x216B96C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60104EE")]
	[Address(RVA = "0x216BE54", Offset = "0x216BE54", VA = "0x216BE54", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60104EF")]
	[Address(RVA = "0x216BF70", Offset = "0x216BF70", VA = "0x216BF70")]
	public void OnExpBonusClick()
	{
	}

	[Token(Token = "0x60104F0")]
	[Address(RVA = "0x216C27C", Offset = "0x216C27C", VA = "0x216C27C")]
	public void OnGoldBonusClick()
	{
	}

	[Token(Token = "0x60104F1")]
	[Address(RVA = "0x216C588", Offset = "0x216C588", VA = "0x216C588")]
	public void OnGoldLimitClick()
	{
	}

	[Token(Token = "0x60104F2")]
	[Address(RVA = "0x216C894", Offset = "0x216C894", VA = "0x216C894")]
	public void OnDebrisLimitClick()
	{
	}

	[Token(Token = "0x60104F3")]
	[Address(RVA = "0x216CBA0", Offset = "0x216CBA0", VA = "0x216CBA0")]
	public void RefreshBonusEventInfo(MapModeData mapModeData, HHDIPHFOBFO groupMode)
	{
	}

	[Token(Token = "0x60104F4")]
	[Address(RVA = "0x216BC9C", Offset = "0x216BC9C", VA = "0x216BC9C")]
	public void HideItems()
	{
	}

	[Token(Token = "0x60104F5")]
	[Address(RVA = "0x216D338", Offset = "0x216D338", VA = "0x216D338")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60104F6")]
	[Address(RVA = "0x216D340", Offset = "0x216D340", VA = "0x216D340")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
