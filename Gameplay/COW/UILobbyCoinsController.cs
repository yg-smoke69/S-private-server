using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002920")]
internal class UILobbyCoinsController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x2002921")]
	private sealed class _003CScrollCoinCount_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FD4C")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CcurCount_003E__0;

		[Token(Token = "0x400FD4D")]
		[FieldOffset(Offset = "0xC")]
		internal int _003CFinalCount_003E__0;

		[Token(Token = "0x400FD4E")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CChangeTime_003E__0;

		[Token(Token = "0x400FD4F")]
		[FieldOffset(Offset = "0x14")]
		internal float _003CdeltaCount_003E__0;

		[Token(Token = "0x400FD50")]
		[FieldOffset(Offset = "0x18")]
		internal float _003CNowCount_003E__1;

		[Token(Token = "0x400FD51")]
		[FieldOffset(Offset = "0x1C")]
		internal UILobbyCoinsController _0024this;

		[Token(Token = "0x400FD52")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x400FD53")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x400FD54")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17001218")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010520")]
			[Address(RVA = "0xD9C718", Offset = "0xD9C718", VA = "0xD9C718", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001219")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010521")]
			[Address(RVA = "0xD9C720", Offset = "0xD9C720", VA = "0xD9C720", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601051E")]
		[Address(RVA = "0xD9C144", Offset = "0xD9C144", VA = "0xD9C144")]
		public _003CScrollCoinCount_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601051F")]
		[Address(RVA = "0xD9C14C", Offset = "0xD9C14C", VA = "0xD9C14C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010522")]
		[Address(RVA = "0xD9C728", Offset = "0xD9C728", VA = "0xD9C728", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010523")]
		[Address(RVA = "0xD9C73C", Offset = "0xD9C73C", VA = "0xD9C73C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FD45")]
	private const string REBATECARDNEWSYSTEMTIPKEY = "REBATECARDNEWSYSTEMTIPKEY_{0}";

	[Token(Token = "0x400FD46")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyCoinsView m_View;

	[Token(Token = "0x400FD47")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelPayment m_Payment;

	[Token(Token = "0x400FD48")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMemberShip m_ModelMembership;

	[Token(Token = "0x400FD49")]
	[FieldOffset(Offset = "0x34")]
	private int m_CurCount;

	[Token(Token = "0x400FD4A")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400FD4B")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6010509")]
	[Address(RVA = "0x2170118", Offset = "0x2170118", VA = "0x2170118")]
	public UILobbyCoinsController()
	{
	}

	[Token(Token = "0x601050A")]
	[Address(RVA = "0x217019C", Offset = "0x217019C", VA = "0x217019C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601050B")]
	[Address(RVA = "0x2170240", Offset = "0x2170240", VA = "0x2170240", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601050C")]
	[Address(RVA = "0x217118C", Offset = "0x217118C", VA = "0x217118C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x601050D")]
	[Address(RVA = "0x217168C", Offset = "0x217168C", VA = "0x217168C")]
	private void OnBtnMonthCardClick()
	{
	}

	[Token(Token = "0x601050E")]
	[Address(RVA = "0x2172148", Offset = "0x2172148", VA = "0x2172148")]
	public void OnClickPayDiamondButton()
	{
	}

	[Token(Token = "0x601050F")]
	[Address(RVA = "0x2172530", Offset = "0x2172530", VA = "0x2172530")]
	public void UpdateCoinsData()
	{
	}

	[Token(Token = "0x6010510")]
	[Address(RVA = "0x21726D4", Offset = "0x21726D4", VA = "0x21726D4")]
	private void RefreshCoinsAndDiamonds(bool bOpenUI)
	{
	}

	[Token(Token = "0x6010511")]
	[Address(RVA = "0x21715C0", Offset = "0x21715C0", VA = "0x21715C0")]
	private IEnumerator ScrollCoinCount()
	{
		return null;
	}

	[Token(Token = "0x6010512")]
	[Address(RVA = "0x2170864", Offset = "0x2170864", VA = "0x2170864")]
	private void RefreshRebateCards()
	{
	}

	[Token(Token = "0x6010513")]
	[Address(RVA = "0x2170DF0", Offset = "0x2170DF0", VA = "0x2170DF0")]
	private void UpdateRebateCardTips()
	{
	}

	[Token(Token = "0x6010514")]
	[Address(RVA = "0x2172D1C", Offset = "0x2172D1C", VA = "0x2172D1C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010515")]
	[Address(RVA = "0x2172E2C", Offset = "0x2172E2C", VA = "0x2172E2C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010516")]
	[Address(RVA = "0x2172EE4", Offset = "0x2172EE4", VA = "0x2172EE4")]
	public void OnCoinsUpdate(object[] data)
	{
	}

	[Token(Token = "0x6010517")]
	[Address(RVA = "0x2172F50", Offset = "0x2172F50", VA = "0x2172F50", Slot = "33")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6010518")]
	[Address(RVA = "0x2170C10", Offset = "0x2170C10", VA = "0x2170C10")]
	private void UpdatePaymentRedDot()
	{
	}

	[Token(Token = "0x6010519")]
	[Address(RVA = "0x2172FF8", Offset = "0x2172FF8", VA = "0x2172FF8")]
	private void _003COnBtnMonthCardClick_003Em__0()
	{
	}

	[Token(Token = "0x601051A")]
	[Address(RVA = "0x217322C", Offset = "0x217322C", VA = "0x217322C")]
	private static void _003COnBtnMonthCardClick_003Em__1()
	{
	}

	[Token(Token = "0x601051B")]
	[Address(RVA = "0x21732C4", Offset = "0x21732C4", VA = "0x21732C4")]
	private static void _003COnClickPayDiamondButton_003Em__2()
	{
	}

	[Token(Token = "0x601051C")]
	[Address(RVA = "0x2173430", Offset = "0x2173430", VA = "0x2173430")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601051D")]
	[Address(RVA = "0x2173438", Offset = "0x2173438", VA = "0x2173438")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
