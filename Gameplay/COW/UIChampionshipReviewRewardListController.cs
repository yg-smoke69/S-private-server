using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002019")]
internal class UIChampionshipReviewRewardListController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x200201A")]
	private sealed class _003CDelayRefreshView_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C99C")]
		[FieldOffset(Offset = "0x8")]
		internal UIChampionshipReviewRewardListController _0024this;

		[Token(Token = "0x400C99D")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C99E")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C99F")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000FD1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A283")]
			[Address(RVA = "0x2839E3C", Offset = "0x2839E3C", VA = "0x2839E3C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FD2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A284")]
			[Address(RVA = "0x2839E44", Offset = "0x2839E44", VA = "0x2839E44", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A281")]
		[Address(RVA = "0x2838D68", Offset = "0x2838D68", VA = "0x2838D68")]
		public _003CDelayRefreshView_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600A282")]
		[Address(RVA = "0x2839718", Offset = "0x2839718", VA = "0x2839718", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A285")]
		[Address(RVA = "0x2839E4C", Offset = "0x2839E4C", VA = "0x2839E4C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A286")]
		[Address(RVA = "0x2839E60", Offset = "0x2839E60", VA = "0x2839E60", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C997")]
	[FieldOffset(Offset = "0x48")]
	private UIChampionshipReviewRewardListView m_View;

	[Token(Token = "0x400C998")]
	[FieldOffset(Offset = "0x4C")]
	private ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

	[Token(Token = "0x400C999")]
	[FieldOffset(Offset = "0x50")]
	private ChampionshipSettingDesc m_ChampionshipSettingInfo;

	[Token(Token = "0x400C99A")]
	[FieldOffset(Offset = "0x54")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C99B")]
	[FieldOffset(Offset = "0x58")]
	private UIClickMask m_Mask;

	[Token(Token = "0x600A270")]
	[Address(RVA = "0x2838238", Offset = "0x2838238", VA = "0x2838238")]
	public UIChampionshipReviewRewardListController()
	{
	}

	[Token(Token = "0x600A271")]
	[Address(RVA = "0x2838240", Offset = "0x2838240", VA = "0x2838240")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A272")]
	[Address(RVA = "0x28382E8", Offset = "0x28382E8", VA = "0x28382E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A273")]
	[Address(RVA = "0x28384F0", Offset = "0x28384F0", VA = "0x28384F0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A274")]
	[Address(RVA = "0x2838568", Offset = "0x2838568", VA = "0x2838568", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A275")]
	[Address(RVA = "0x28385C0", Offset = "0x28385C0", VA = "0x28385C0")]
	private void OnCloseButtonClick()
	{
	}

	[Token(Token = "0x600A276")]
	[Address(RVA = "0x2838624", Offset = "0x2838624", VA = "0x2838624")]
	public void SetChampionshipInfo(ChampionshipOpenInfoDesc championshipOpenInfo)
	{
	}

	[Token(Token = "0x600A277")]
	[Address(RVA = "0x28386C0", Offset = "0x28386C0", VA = "0x28386C0")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x600A278")]
	[Address(RVA = "0x2838810", Offset = "0x2838810", VA = "0x2838810")]
	private void ReviseScrollView()
	{
	}

	[Token(Token = "0x600A279")]
	[Address(RVA = "0x2838744", Offset = "0x2838744", VA = "0x2838744")]
	private IEnumerator DelayRefreshView()
	{
		return null;
	}

	[Token(Token = "0x600A27A")]
	[Address(RVA = "0x2838D70", Offset = "0x2838D70", VA = "0x2838D70")]
	private void RefreshChampionReward()
	{
	}

	[Token(Token = "0x600A27B")]
	[Address(RVA = "0x2839304", Offset = "0x2839304", VA = "0x2839304", Slot = "48")]
	protected virtual void RefreshCupIcon()
	{
	}

	[Token(Token = "0x600A27C")]
	[Address(RVA = "0x283958C", Offset = "0x283958C", VA = "0x283958C", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A27D")]
	[Address(RVA = "0x2839684", Offset = "0x2839684", VA = "0x2839684", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A27E")]
	[Address(RVA = "0x2839700", Offset = "0x2839700", VA = "0x2839700")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A27F")]
	[Address(RVA = "0x2839708", Offset = "0x2839708", VA = "0x2839708")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A280")]
	[Address(RVA = "0x2839710", Offset = "0x2839710", VA = "0x2839710")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
