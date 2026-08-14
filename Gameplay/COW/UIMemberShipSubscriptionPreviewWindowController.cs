using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20029C8")]
public class UIMemberShipSubscriptionPreviewWindowController : UIPopupWindowController
{
	[Token(Token = "0x20029C9")]
	private sealed class _003CInitHelper_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010103")]
		[FieldOffset(Offset = "0x8")]
		internal UIMemberShipSubscriptionPreviewWindowController _0024this;

		[Token(Token = "0x4010104")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010105")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010106")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700126A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010CEB")]
			[Address(RVA = "0x130748C", Offset = "0x130748C", VA = "0x130748C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700126B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010CEC")]
			[Address(RVA = "0x1307494", Offset = "0x1307494", VA = "0x1307494", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010CE9")]
		[Address(RVA = "0x13073C0", Offset = "0x13073C0", VA = "0x13073C0")]
		public _003CInitHelper_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6010CEA")]
		[Address(RVA = "0x13073D0", Offset = "0x13073D0", VA = "0x13073D0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010CED")]
		[Address(RVA = "0x130749C", Offset = "0x130749C", VA = "0x130749C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010CEE")]
		[Address(RVA = "0x13074B0", Offset = "0x13074B0", VA = "0x13074B0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010100")]
	[FieldOffset(Offset = "0x48")]
	private UIModelMemberShip m_ModelMemberShip;

	[Token(Token = "0x4010101")]
	[FieldOffset(Offset = "0x4C")]
	private UIMemberShipSubscriptionPreviewWindowView m_View;

	[Token(Token = "0x4010102")]
	[FieldOffset(Offset = "0x50")]
	private EVipCard.VipCardType m_MemberShipCardType;

	[Token(Token = "0x6010CDA")]
	[Address(RVA = "0x1305C60", Offset = "0x1305C60", VA = "0x1305C60")]
	public UIMemberShipSubscriptionPreviewWindowController()
	{
	}

	[Token(Token = "0x6010CDB")]
	[Address(RVA = "0x1305C68", Offset = "0x1305C68", VA = "0x1305C68")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010CDC")]
	[Address(RVA = "0x1305D0C", Offset = "0x1305D0C", VA = "0x1305D0C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010CDD")]
	[Address(RVA = "0x1305FC8", Offset = "0x1305FC8", VA = "0x1305FC8")]
	private void SetLegalTexts()
	{
	}

	[Token(Token = "0x6010CDE")]
	[Address(RVA = "0x13064E8", Offset = "0x13064E8", VA = "0x13064E8")]
	public void SetViewData(EVipCard.VipCardType type)
	{
	}

	[Token(Token = "0x6010CDF")]
	[Address(RVA = "0x13065B0", Offset = "0x13065B0", VA = "0x13065B0")]
	private void UpdateBonus()
	{
	}

	[Token(Token = "0x6010CE0")]
	[Address(RVA = "0x1306A8C", Offset = "0x1306A8C", VA = "0x1306A8C")]
	private void UpdatePeriodLabel(PayItemData csv, PayItemData sdk)
	{
	}

	[Token(Token = "0x6010CE1")]
	[Address(RVA = "0x1306794", Offset = "0x1306794", VA = "0x1306794")]
	private void GetProduct(out PayItemData csv, out PayItemData sdk)
	{
	}

	[Token(Token = "0x6010CE2")]
	[Address(RVA = "0x13068BC", Offset = "0x13068BC", VA = "0x13068BC")]
	private void UpdatePriceLabel(PayItemData csv, PayItemData sdk)
	{
	}

	[Token(Token = "0x6010CE3")]
	[Address(RVA = "0x1306D98", Offset = "0x1306D98", VA = "0x1306D98")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x6010CE4")]
	[Address(RVA = "0x1306DFC", Offset = "0x1306DFC", VA = "0x1306DFC")]
	private void OnBtnSubscribeClick()
	{
	}

	[Token(Token = "0x6010CE5")]
	[Address(RVA = "0x1307230", Offset = "0x1307230", VA = "0x1307230")]
	private void OnBtnTermsOfServiceClick()
	{
	}

	[Token(Token = "0x6010CE6")]
	[Address(RVA = "0x13072F8", Offset = "0x13072F8", VA = "0x13072F8")]
	private void OnBtnPrivacyPolicyClick()
	{
	}

	[Token(Token = "0x6010CE7")]
	[Address(RVA = "0x1306CCC", Offset = "0x1306CCC", VA = "0x1306CCC")]
	private IEnumerator InitHelper()
	{
		return null;
	}

	[Token(Token = "0x6010CE8")]
	[Address(RVA = "0x13073C8", Offset = "0x13073C8", VA = "0x13073C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
