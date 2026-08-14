using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021FF")]
public class UINormalMallDetailController : UIMallDetailBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x2002200")]
	private enum MallDetailType
	{
		[Token(Token = "0x400D4F0")]
		Normal,
		[Token(Token = "0x400D4F1")]
		AD,
		[Token(Token = "0x400D4F2")]
		Discount,
		[Token(Token = "0x400D4F3")]
		Installment
	}

	[Token(Token = "0x2002201")]
	private abstract class MallDetail
	{
		[Token(Token = "0x400D4F4")]
		[FieldOffset(Offset = "0x8")]
		protected UINormalMallDetailController m_MallDetailCtrl;

		[Token(Token = "0x400D4F5")]
		[FieldOffset(Offset = "0xC")]
		protected UIModelMall m_ModelMall;

		[Token(Token = "0x400D4F6")]
		[FieldOffset(Offset = "0x10")]
		protected UIModelInventory m_ModelInventory;

		[Token(Token = "0x400D4F7")]
		[FieldOffset(Offset = "0x14")]
		protected UIMallDetailView m_View;

		[Token(Token = "0x600B7D4")]
		[Address(RVA = "0x26DE8B4", Offset = "0x26DE8B4", VA = "0x26DE8B4")]
		public MallDetail(UINormalMallDetailController mallDetailCtrl)
		{
		}

		[Token(Token = "0x600B7D5")]
		public abstract UIEasyListItemController OpenItemController(Transform parent);

		[Token(Token = "0x600B7D6")]
		public abstract void CloseItemController(UIEasyListItemController itemController);

		[Token(Token = "0x600B7D7")]
		public abstract void HighLightItem(uint storeID);

		[Token(Token = "0x600B7D8")]
		public abstract void BuyStoreItem(uint storeID);

		[Token(Token = "0x600B7D9")]
		public abstract void RefreshItemView(uint itemID);

		[Token(Token = "0x600B7DA")]
		public abstract void UnSelectItem(uint itemID);

		[Token(Token = "0x600B7DB")]
		public abstract void HideItemEffect();

		[Token(Token = "0x600B7DC")]
		public abstract bool CanFindStoreItem(uint storeID);

		[Token(Token = "0x600B7DD")]
		public abstract MallDetailType GetMallDetailType();
	}

	[Token(Token = "0x2002202")]
	private class ADDetail : MallDetail
	{
		[Token(Token = "0x2002203")]
		private sealed class _003CHighLightItem_003Ec__AnonStorey0
		{
			[Token(Token = "0x400D4F9")]
			[FieldOffset(Offset = "0x8")]
			internal uint storeID;

			[Token(Token = "0x600B7E9")]
			[Address(RVA = "0x26DED7C", Offset = "0x26DED7C", VA = "0x26DED7C")]
			public _003CHighLightItem_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x600B7EA")]
			[Address(RVA = "0x26DEFD4", Offset = "0x26DEFD4", VA = "0x26DEFD4")]
			internal bool _003C_003Em__0(StoreDesc item)
			{
				return default(bool);
			}

			[Token(Token = "0x600B7EB")]
			[Address(RVA = "0x26DF00C", Offset = "0x26DF00C", VA = "0x26DF00C")]
			internal bool _003C_003Em__1(StoreDesc item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400D4F8")]
		[FieldOffset(Offset = "0x18")]
		private List<StoreDesc> m_DataList;

		[Token(Token = "0x600B7DE")]
		[Address(RVA = "0x26DB870", Offset = "0x26DB870", VA = "0x26DB870")]
		public ADDetail(UINormalMallDetailController mallDetailCtrl)
		{
		}

		[Token(Token = "0x600B7DF")]
		[Address(RVA = "0x26DE9E4", Offset = "0x26DE9E4", VA = "0x26DE9E4", Slot = "4")]
		public override UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600B7E0")]
		[Address(RVA = "0x26DEAB0", Offset = "0x26DEAB0", VA = "0x26DEAB0", Slot = "5")]
		public override void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600B7E1")]
		[Address(RVA = "0x26DEB2C", Offset = "0x26DEB2C", VA = "0x26DEB2C", Slot = "6")]
		public override void HighLightItem(uint storeID)
		{
		}

		[Token(Token = "0x600B7E2")]
		[Address(RVA = "0x26DB874", Offset = "0x26DB874", VA = "0x26DB874")]
		public void RefreshDataList(List<StoreDesc> dataList)
		{
		}

		[Token(Token = "0x600B7E3")]
		[Address(RVA = "0x26DED84", Offset = "0x26DED84", VA = "0x26DED84", Slot = "7")]
		public override void BuyStoreItem(uint storeID)
		{
		}

		[Token(Token = "0x600B7E4")]
		[Address(RVA = "0x26DEDE0", Offset = "0x26DEDE0", VA = "0x26DEDE0", Slot = "8")]
		public override void RefreshItemView(uint itemID)
		{
		}

		[Token(Token = "0x600B7E5")]
		[Address(RVA = "0x26DEE3C", Offset = "0x26DEE3C", VA = "0x26DEE3C", Slot = "12")]
		public override MallDetailType GetMallDetailType()
		{
			return default(MallDetailType);
		}

		[Token(Token = "0x600B7E6")]
		[Address(RVA = "0x26DEE94", Offset = "0x26DEE94", VA = "0x26DEE94", Slot = "9")]
		public override void UnSelectItem(uint itemID)
		{
		}

		[Token(Token = "0x600B7E7")]
		[Address(RVA = "0x26DEEF0", Offset = "0x26DEEF0", VA = "0x26DEEF0", Slot = "10")]
		public override void HideItemEffect()
		{
		}

		[Token(Token = "0x600B7E8")]
		[Address(RVA = "0x26DEF44", Offset = "0x26DEF44", VA = "0x26DEF44", Slot = "11")]
		public override bool CanFindStoreItem(uint storeID)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002204")]
	private class NormalDetail : MallDetail
	{
		[Token(Token = "0x2002205")]
		private sealed class _003CHighLightItem_003Ec__AnonStorey0
		{
			[Token(Token = "0x400D4FB")]
			[FieldOffset(Offset = "0x8")]
			internal uint storeID;

			[Token(Token = "0x600B7F7")]
			[Address(RVA = "0x26E0BA4", Offset = "0x26E0BA4", VA = "0x26E0BA4")]
			public _003CHighLightItem_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x600B7F8")]
			[Address(RVA = "0x26E16DC", Offset = "0x26E16DC", VA = "0x26E16DC")]
			internal bool _003C_003Em__0(StoreDesc item)
			{
				return default(bool);
			}

			[Token(Token = "0x600B7F9")]
			[Address(RVA = "0x26E1714", Offset = "0x26E1714", VA = "0x26E1714")]
			internal bool _003C_003Em__1(StoreDesc item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2002206")]
		private sealed class _003CUnSelectItem_003Ec__AnonStorey1
		{
			[Token(Token = "0x400D4FC")]
			[FieldOffset(Offset = "0x8")]
			internal uint itemID;

			[Token(Token = "0x600B7FA")]
			[Address(RVA = "0x26E13FC", Offset = "0x26E13FC", VA = "0x26E13FC")]
			public _003CUnSelectItem_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x600B7FB")]
			[Address(RVA = "0x26E174C", Offset = "0x26E174C", VA = "0x26E174C")]
			internal bool _003C_003Em__0(StoreDesc item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400D4FA")]
		[FieldOffset(Offset = "0x18")]
		private List<StoreDesc> m_DataList;

		[Token(Token = "0x600B7EC")]
		[Address(RVA = "0x26DB524", Offset = "0x26DB524", VA = "0x26DB524")]
		public NormalDetail(UINormalMallDetailController mallDetailCtrl)
		{
		}

		[Token(Token = "0x600B7ED")]
		[Address(RVA = "0x26E0658", Offset = "0x26E0658", VA = "0x26E0658", Slot = "4")]
		public override UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600B7EE")]
		[Address(RVA = "0x26E0724", Offset = "0x26E0724", VA = "0x26E0724", Slot = "5")]
		public override void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600B7EF")]
		[Address(RVA = "0x26E07A0", Offset = "0x26E07A0", VA = "0x26E07A0", Slot = "6")]
		public override void HighLightItem(uint storeID)
		{
		}

		[Token(Token = "0x600B7F0")]
		[Address(RVA = "0x26D6800", Offset = "0x26D6800", VA = "0x26D6800")]
		public void RefreshDataList(List<StoreDesc> dataList)
		{
		}

		[Token(Token = "0x600B7F1")]
		[Address(RVA = "0x26E0BAC", Offset = "0x26E0BAC", VA = "0x26E0BAC", Slot = "7")]
		public override void BuyStoreItem(uint storeID)
		{
		}

		[Token(Token = "0x600B7F2")]
		[Address(RVA = "0x26E0F0C", Offset = "0x26E0F0C", VA = "0x26E0F0C", Slot = "8")]
		public override void RefreshItemView(uint itemId)
		{
		}

		[Token(Token = "0x600B7F3")]
		[Address(RVA = "0x26E1228", Offset = "0x26E1228", VA = "0x26E1228", Slot = "12")]
		public override MallDetailType GetMallDetailType()
		{
			return default(MallDetailType);
		}

		[Token(Token = "0x600B7F4")]
		[Address(RVA = "0x26E1280", Offset = "0x26E1280", VA = "0x26E1280", Slot = "9")]
		public override void UnSelectItem(uint itemID)
		{
		}

		[Token(Token = "0x600B7F5")]
		[Address(RVA = "0x26E1404", Offset = "0x26E1404", VA = "0x26E1404", Slot = "10")]
		public override void HideItemEffect()
		{
		}

		[Token(Token = "0x600B7F6")]
		[Address(RVA = "0x26E164C", Offset = "0x26E164C", VA = "0x26E164C", Slot = "11")]
		public override bool CanFindStoreItem(uint storeID)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002207")]
	private class DiscountDetail : MallDetail
	{
		[Token(Token = "0x2002208")]
		private sealed class _003CHighLightItem_003Ec__AnonStorey0
		{
			[Token(Token = "0x400D4FE")]
			[FieldOffset(Offset = "0x8")]
			internal uint storeID;

			[Token(Token = "0x600B807")]
			[Address(RVA = "0x26DF3E4", Offset = "0x26DF3E4", VA = "0x26DF3E4")]
			public _003CHighLightItem_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x600B808")]
			[Address(RVA = "0x26DFDB0", Offset = "0x26DFDB0", VA = "0x26DFDB0")]
			internal bool _003C_003Em__0(DiscountStoreDesc item)
			{
				return default(bool);
			}

			[Token(Token = "0x600B809")]
			[Address(RVA = "0x26DFDE8", Offset = "0x26DFDE8", VA = "0x26DFDE8")]
			internal bool _003C_003Em__1(DiscountStoreDesc item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2002209")]
		private sealed class _003CUnSelectItem_003Ec__AnonStorey1
		{
			[Token(Token = "0x400D4FF")]
			[FieldOffset(Offset = "0x8")]
			internal uint itemID;

			[Token(Token = "0x600B80A")]
			[Address(RVA = "0x26DFB60", Offset = "0x26DFB60", VA = "0x26DFB60")]
			public _003CUnSelectItem_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x600B80B")]
			[Address(RVA = "0x26DFE20", Offset = "0x26DFE20", VA = "0x26DFE20")]
			internal bool _003C_003Em__0(DiscountStoreDesc item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400D4FD")]
		[FieldOffset(Offset = "0x18")]
		private List<DiscountStoreDesc> m_DataList;

		[Token(Token = "0x600B7FC")]
		[Address(RVA = "0x26DC574", Offset = "0x26DC574", VA = "0x26DC574")]
		public DiscountDetail(UINormalMallDetailController mallDetailCtrl)
		{
		}

		[Token(Token = "0x600B7FD")]
		[Address(RVA = "0x26DF044", Offset = "0x26DF044", VA = "0x26DF044", Slot = "4")]
		public override UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600B7FE")]
		[Address(RVA = "0x26DF110", Offset = "0x26DF110", VA = "0x26DF110", Slot = "5")]
		public override void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600B7FF")]
		[Address(RVA = "0x26DF18C", Offset = "0x26DF18C", VA = "0x26DF18C", Slot = "6")]
		public override void HighLightItem(uint storeID)
		{
		}

		[Token(Token = "0x600B800")]
		[Address(RVA = "0x26DC578", Offset = "0x26DC578", VA = "0x26DC578")]
		public void RefreshData(List<DiscountStoreDesc> dataList)
		{
		}

		[Token(Token = "0x600B801")]
		[Address(RVA = "0x26DF3EC", Offset = "0x26DF3EC", VA = "0x26DF3EC", Slot = "7")]
		public override void BuyStoreItem(uint storeID)
		{
		}

		[Token(Token = "0x600B802")]
		[Address(RVA = "0x26DF724", Offset = "0x26DF724", VA = "0x26DF724", Slot = "8")]
		public override void RefreshItemView(uint itemID)
		{
		}

		[Token(Token = "0x600B803")]
		[Address(RVA = "0x26DF984", Offset = "0x26DF984", VA = "0x26DF984", Slot = "12")]
		public override MallDetailType GetMallDetailType()
		{
			return default(MallDetailType);
		}

		[Token(Token = "0x600B804")]
		[Address(RVA = "0x26DF9DC", Offset = "0x26DF9DC", VA = "0x26DF9DC", Slot = "9")]
		public override void UnSelectItem(uint itemID)
		{
		}

		[Token(Token = "0x600B805")]
		[Address(RVA = "0x26DFB68", Offset = "0x26DFB68", VA = "0x26DFB68", Slot = "10")]
		public override void HideItemEffect()
		{
		}

		[Token(Token = "0x600B806")]
		[Address(RVA = "0x26DFD24", Offset = "0x26DFD24", VA = "0x26DFD24", Slot = "11")]
		public override bool CanFindStoreItem(uint storeID)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200220A")]
	private class InstallmentDetail : MallDetail
	{
		[Token(Token = "0x200220B")]
		private sealed class _003CHighLightItem_003Ec__AnonStorey0
		{
			[Token(Token = "0x400D501")]
			[FieldOffset(Offset = "0x8")]
			internal uint storeID;

			[Token(Token = "0x600B817")]
			[Address(RVA = "0x26E017C", Offset = "0x26E017C", VA = "0x26E017C")]
			public _003CHighLightItem_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x600B818")]
			[Address(RVA = "0x26E05E8", Offset = "0x26E05E8", VA = "0x26E05E8")]
			internal bool _003C_003Em__0(InstallmentStoreDesc item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200220C")]
		private sealed class _003CUnSelectItem_003Ec__AnonStorey1
		{
			[Token(Token = "0x400D502")]
			[FieldOffset(Offset = "0x8")]
			internal uint itemID;

			[Token(Token = "0x600B819")]
			[Address(RVA = "0x26E0528", Offset = "0x26E0528", VA = "0x26E0528")]
			public _003CUnSelectItem_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x600B81A")]
			[Address(RVA = "0x26E0620", Offset = "0x26E0620", VA = "0x26E0620")]
			internal bool _003C_003Em__0(InstallmentStoreDesc item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400D500")]
		[FieldOffset(Offset = "0x18")]
		private List<InstallmentStoreDesc> m_DataList;

		[Token(Token = "0x600B80C")]
		[Address(RVA = "0x26DC83C", Offset = "0x26DC83C", VA = "0x26DC83C")]
		public InstallmentDetail(UINormalMallDetailController mallDetailCtrl)
		{
		}

		[Token(Token = "0x600B80D")]
		[Address(RVA = "0x26DFE58", Offset = "0x26DFE58", VA = "0x26DFE58", Slot = "4")]
		public override UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600B80E")]
		[Address(RVA = "0x26DFF24", Offset = "0x26DFF24", VA = "0x26DFF24", Slot = "5")]
		public override void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600B80F")]
		[Address(RVA = "0x26DFFA0", Offset = "0x26DFFA0", VA = "0x26DFFA0", Slot = "6")]
		public override void HighLightItem(uint storeID)
		{
		}

		[Token(Token = "0x600B810")]
		[Address(RVA = "0x26DC840", Offset = "0x26DC840", VA = "0x26DC840")]
		public void RefreshDataList(List<InstallmentStoreDesc> dataList)
		{
		}

		[Token(Token = "0x600B811")]
		[Address(RVA = "0x26E0184", Offset = "0x26E0184", VA = "0x26E0184", Slot = "8")]
		public override void RefreshItemView(uint itemID)
		{
		}

		[Token(Token = "0x600B812")]
		[Address(RVA = "0x26E02F0", Offset = "0x26E02F0", VA = "0x26E02F0", Slot = "7")]
		public override void BuyStoreItem(uint storeID)
		{
		}

		[Token(Token = "0x600B813")]
		[Address(RVA = "0x26E034C", Offset = "0x26E034C", VA = "0x26E034C", Slot = "12")]
		public override MallDetailType GetMallDetailType()
		{
			return default(MallDetailType);
		}

		[Token(Token = "0x600B814")]
		[Address(RVA = "0x26E03A4", Offset = "0x26E03A4", VA = "0x26E03A4", Slot = "9")]
		public override void UnSelectItem(uint itemID)
		{
		}

		[Token(Token = "0x600B815")]
		[Address(RVA = "0x26E0530", Offset = "0x26E0530", VA = "0x26E0530", Slot = "10")]
		public override void HideItemEffect()
		{
		}

		[Token(Token = "0x600B816")]
		[Address(RVA = "0x26E0584", Offset = "0x26E0584", VA = "0x26E0584", Slot = "11")]
		public override bool CanFindStoreItem(uint storeID)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200220D")]
	private sealed class _003COnSubToggleClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D503")]
		[FieldOffset(Offset = "0x8")]
		internal Dictionary<int, SlotClothInfo> selectedClothDict;

		[Token(Token = "0x400D504")]
		[FieldOffset(Offset = "0xC")]
		internal UINormalMallDetailController _0024this;

		[Token(Token = "0x600B81B")]
		[Address(RVA = "0x26D6088", Offset = "0x26D6088", VA = "0x26D6088")]
		public _003COnSubToggleClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B81C")]
		[Address(RVA = "0x26DE7E4", Offset = "0x26DE7E4", VA = "0x26DE7E4")]
		internal bool _003C_003Em__0(StoreDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200220E")]
	private sealed class _003COnClothPreviewToggleClick_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D505")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x600B81D")]
		[Address(RVA = "0x26D6FF0", Offset = "0x26D6FF0", VA = "0x26D6FF0")]
		public _003COnClothPreviewToggleClick_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600B81E")]
		[Address(RVA = "0x26DE7AC", Offset = "0x26DE7AC", VA = "0x26DE7AC")]
		internal bool _003C_003Em__0(StoreDesc cloth)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200220F")]
	private sealed class _003CNavigationToItem_003Ec__AnonStorey2
	{
		[Token(Token = "0x400D506")]
		[FieldOffset(Offset = "0x8")]
		internal uint mallSubType;

		[Token(Token = "0x600B81F")]
		[Address(RVA = "0x26DCEA0", Offset = "0x26DCEA0", VA = "0x26DCEA0")]
		public _003CNavigationToItem_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600B820")]
		[Address(RVA = "0x26DE774", Offset = "0x26DE774", VA = "0x26DE774")]
		internal bool _003C_003Em__0(SubTabInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002210")]
	private sealed class _003CGenderSelectionList_003Ec__AnonStorey3
	{
		[Token(Token = "0x400D507")]
		[FieldOffset(Offset = "0x8")]
		internal EClothGenderType genderType;

		[Token(Token = "0x400D508")]
		[FieldOffset(Offset = "0xC")]
		internal UINormalMallDetailController _0024this;

		[Token(Token = "0x600B821")]
		[Address(RVA = "0x26DD7A8", Offset = "0x26DD7A8", VA = "0x26DD7A8")]
		public _003CGenderSelectionList_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600B822")]
		[Address(RVA = "0x26DE720", Offset = "0x26DE720", VA = "0x26DE720")]
		internal bool _003C_003Em__0(StoreDesc storeItem)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D4C9")]
	[FieldOffset(Offset = "0xB8")]
	private List<UIMallADsItemController> m_AdList;

	[Token(Token = "0x400D4CA")]
	[FieldOffset(Offset = "0xBC")]
	private List<UILobbyDotController> m_DotCtrls;

	[Token(Token = "0x400D4CB")]
	[FieldOffset(Offset = "0xC0")]
	private int m_DotIndex;

	[Token(Token = "0x400D4CC")]
	[FieldOffset(Offset = "0xC4")]
	private uint m_AutoScrollDelayCallID;

	[Token(Token = "0x400D4CD")]
	[FieldOffset(Offset = "0xC8")]
	private UILobbyDotController m_CarouselSlider;

	[Token(Token = "0x400D4CE")]
	[FieldOffset(Offset = "0xCC")]
	private UILobbyDotController m_CarouselSlider2;

	[Token(Token = "0x400D4CF")]
	[FieldOffset(Offset = "0xD0")]
	protected List<StoreDesc> m_CurrentDataList;

	[Token(Token = "0x400D4D0")]
	[FieldOffset(Offset = "0xD4")]
	private List<StoreDesc> m_RecommendItemList;

	[Token(Token = "0x400D4D1")]
	[FieldOffset(Offset = "0xD8")]
	private List<DiscountStoreDesc> m_DiscountItemList;

	[Token(Token = "0x400D4D2")]
	[FieldOffset(Offset = "0xDC")]
	private bool m_PurchaseSuccess;

	[Token(Token = "0x400D4D3")]
	[FieldOffset(Offset = "0xE0")]
	private ADDetail m_ADDetail;

	[Token(Token = "0x400D4D4")]
	[FieldOffset(Offset = "0xE4")]
	private NormalDetail m_NormalDetail;

	[Token(Token = "0x400D4D5")]
	[FieldOffset(Offset = "0xE8")]
	private DiscountDetail m_DiscountDetail;

	[Token(Token = "0x400D4D6")]
	[FieldOffset(Offset = "0xEC")]
	private InstallmentDetail m_InstallmentDetail;

	[Token(Token = "0x400D4D7")]
	[FieldOffset(Offset = "0xF0")]
	private MallDetail m_CurrentMallDetail;

	[Token(Token = "0x400D4D8")]
	[FieldOffset(Offset = "0xF4")]
	private UIModelMysteryMall m_ModelMystery;

	[Token(Token = "0x400D4D9")]
	[FieldOffset(Offset = "0xF8")]
	private uint m_BookID;

	[Token(Token = "0x400D4DA")]
	[FieldOffset(Offset = "0xFC")]
	private uint m_SelectedPageID;

	[Token(Token = "0x400D4DB")]
	[FieldOffset(Offset = "0x100")]
	private Dictionary<uint, int> m_TabOrderDict;

	[Token(Token = "0x400D4DC")]
	[FieldOffset(Offset = "0x104")]
	private UIModelOptionalDownload m_ModelOpDownload;

	[Token(Token = "0x400D4DD")]
	[FieldOffset(Offset = "0x108")]
	private uint m_DiscountAnimDelayCall;

	[Token(Token = "0x400D4DE")]
	[FieldOffset(Offset = "0x10C")]
	private uint m_DiscountAnimCounter;

	[Token(Token = "0x400D4DF")]
	[FieldOffset(Offset = "0x110")]
	private UICountDownController m_DiscountCountDownCtrl;

	[Token(Token = "0x400D4E0")]
	private const uint MAX_ADS_COUNT = 10u;

	[Token(Token = "0x400D4E1")]
	private const uint CAROUSEL_MAX_WIDTH = 400u;

	[Token(Token = "0x400D4E2")]
	private const uint CAROUSEL_EACH_WIDTH_DEFAULT = 60u;

	[Token(Token = "0x400D4E3")]
	private const uint CAROUSEL_GAP_WIDTH = 5u;

	[Token(Token = "0x400D4E4")]
	private const uint ADS_WIDTH = 502u;

	[Token(Token = "0x400D4E5")]
	private const uint ADS_OFFSET = 27u;

	[Token(Token = "0x400D4E6")]
	[FieldOffset(Offset = "0x114")]
	private float m_FirstCarouselX;

	[Token(Token = "0x400D4E7")]
	[FieldOffset(Offset = "0x118")]
	private float m_StepCarouselX;

	[Token(Token = "0x400D4E8")]
	[FieldOffset(Offset = "0x11C")]
	private bool m_CarouselIsMoving;

	[Token(Token = "0x400D4E9")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<SubTabInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D4EA")]
	[FieldOffset(Offset = "0x4")]
	private static Func<AdItemInfo, int, bool> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400D4EB")]
	[FieldOffset(Offset = "0x8")]
	private static Func<AdItemInfo, int, bool> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400D4EC")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<AdItemInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400D4ED")]
	[FieldOffset(Offset = "0x10")]
	private static Func<StoreDesc, bool> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400D4EE")]
	[FieldOffset(Offset = "0x14")]
	private static Converter<UINavigationUtil.UINavigationMallTabType, uint> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x600B769")]
	[Address(RVA = "0x26D1498", Offset = "0x26D1498", VA = "0x26D1498")]
	public UINormalMallDetailController()
	{
	}

	[Token(Token = "0x600B76A")]
	[Address(RVA = "0x26D1834", Offset = "0x26D1834", VA = "0x26D1834")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B76B")]
	[Address(RVA = "0x26D18D8", Offset = "0x26D18D8", VA = "0x26D18D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B76C")]
	[Address(RVA = "0x26D28CC", Offset = "0x26D28CC", VA = "0x26D28CC")]
	private void SetCarouselStop()
	{
	}

	[Token(Token = "0x600B76D")]
	[Address(RVA = "0x26D2928", Offset = "0x26D2928", VA = "0x26D2928")]
	private void Update()
	{
	}

	[Token(Token = "0x600B76E")]
	[Address(RVA = "0x26D2FF4", Offset = "0x26D2FF4", VA = "0x26D2FF4", Slot = "31")]
	protected override void InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B76F")]
	[Address(RVA = "0x26D3FC8", Offset = "0x26D3FC8", VA = "0x26D3FC8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B770")]
	[Address(RVA = "0x26D43CC", Offset = "0x26D43CC", VA = "0x26D43CC")]
	private void OnRecommendGoBtnClick()
	{
	}

	[Token(Token = "0x600B771")]
	[Address(RVA = "0x26D4530", Offset = "0x26D4530", VA = "0x26D4530")]
	private void OnHyperBookGoBtnClick()
	{
	}

	[Token(Token = "0x600B772")]
	[Address(RVA = "0x26D4960", Offset = "0x26D4960", VA = "0x26D4960")]
	private void OnFreeBtnClick()
	{
	}

	[Token(Token = "0x600B773")]
	[Address(RVA = "0x26D4A04", Offset = "0x26D4A04", VA = "0x26D4A04")]
	private void OnInstallmentBtnClick()
	{
	}

	[Token(Token = "0x600B774")]
	[Address(RVA = "0x26D4DB8", Offset = "0x26D4DB8", VA = "0x26D4DB8")]
	private void OnBuyBtnClick()
	{
	}

	[Token(Token = "0x600B775")]
	[Address(RVA = "0x26D503C", Offset = "0x26D503C", VA = "0x26D503C")]
	private void OnInstallmentTutorialBtnClick()
	{
	}

	[Token(Token = "0x600B776")]
	[Address(RVA = "0x26D2424", Offset = "0x26D2424", VA = "0x26D2424")]
	private void InitMallTypeHandle()
	{
	}

	[Token(Token = "0x600B777")]
	[Address(RVA = "0x26D5090", Offset = "0x26D5090", VA = "0x26D5090", Slot = "55")]
	protected override void OnSubToggleClick()
	{
	}

	[Token(Token = "0x600B778")]
	[Address(RVA = "0x26D6860", Offset = "0x26D6860", VA = "0x26D6860", Slot = "32")]
	protected override void OnClothPreviewToggleClick()
	{
	}

	[Token(Token = "0x600B779")]
	[Address(RVA = "0x26D7340", Offset = "0x26D7340", VA = "0x26D7340", Slot = "58")]
	public override void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600B77A")]
	[Address(RVA = "0x26D7898", Offset = "0x26D7898", VA = "0x26D7898", Slot = "33")]
	protected override void UnSelectItem(uint itemID)
	{
	}

	[Token(Token = "0x600B77B")]
	[Address(RVA = "0x26D748C", Offset = "0x26D748C", VA = "0x26D748C")]
	protected void RefreshItemView(uint storeID, uint itemID)
	{
	}

	[Token(Token = "0x600B77C")]
	[Address(RVA = "0x26D7934", Offset = "0x26D7934", VA = "0x26D7934")]
	private void SetLabelLimitedCountText(uint limited_purchase_times, uint purchase_times)
	{
	}

	[Token(Token = "0x600B77D")]
	[Address(RVA = "0x26D6090", Offset = "0x26D6090", VA = "0x26D6090")]
	private void RefreshViewData(List<StoreDesc> dataList, bool needSort = true)
	{
	}

	[Token(Token = "0x600B77E")]
	[Address(RVA = "0x26D7C04", Offset = "0x26D7C04", VA = "0x26D7C04")]
	private void RefreshDiscountViewData(List<DiscountStoreDesc> dataList, bool needSort = true)
	{
	}

	[Token(Token = "0x600B77F")]
	[Address(RVA = "0x26D7DBC", Offset = "0x26D7DBC", VA = "0x26D7DBC")]
	private void RefreshInstallmentViewData(List<InstallmentStoreDesc> dataList, bool needSort = true)
	{
	}

	[Token(Token = "0x600B780")]
	[Address(RVA = "0x26D7F74", Offset = "0x26D7F74", VA = "0x26D7F74")]
	private void RefreshRecommendViewData()
	{
	}

	[Token(Token = "0x600B781")]
	[Address(RVA = "0x26D8388", Offset = "0x26D8388", VA = "0x26D8388")]
	private void JumptoItem(object[] data)
	{
	}

	[Token(Token = "0x600B782")]
	[Address(RVA = "0x26D85CC", Offset = "0x26D85CC", VA = "0x26D85CC")]
	private void ClickHyperBookItem(object[] data)
	{
	}

	[Token(Token = "0x600B783")]
	[Address(RVA = "0x26D5FD8", Offset = "0x26D5FD8", VA = "0x26D5FD8")]
	private void ResetHyperBookGotoBtnState()
	{
	}

	[Token(Token = "0x600B784")]
	[Address(RVA = "0x26D6610", Offset = "0x26D6610", VA = "0x26D6610")]
	public void ClickHyperBookTab(uint bookID)
	{
	}

	[Token(Token = "0x600B785")]
	[Address(RVA = "0x26D8860", Offset = "0x26D8860", VA = "0x26D8860")]
	private void OnRecommendItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600B786")]
	[Address(RVA = "0x26D89DC", Offset = "0x26D89DC", VA = "0x26D89DC", Slot = "74")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B787")]
	[Address(RVA = "0x26D8A94", Offset = "0x26D8A94", VA = "0x26D8A94", Slot = "73")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B788")]
	[Address(RVA = "0x26D8D68", Offset = "0x26D8D68", VA = "0x26D8D68", Slot = "35")]
	protected override bool CanFindStoreItem(uint storeID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B789")]
	[Address(RVA = "0x26D2994", Offset = "0x26D2994", VA = "0x26D2994")]
	private void OnADScrollViewMove()
	{
	}

	[Token(Token = "0x600B78A")]
	[Address(RVA = "0x26D8DF0", Offset = "0x26D8DF0", VA = "0x26D8DF0")]
	private void RefreshAdsView()
	{
	}

	[Token(Token = "0x600B78B")]
	[Address(RVA = "0x26D98F4", Offset = "0x26D98F4", VA = "0x26D98F4")]
	private void OnAutoScrollAdItem()
	{
	}

	[Token(Token = "0x600B78C")]
	[Address(RVA = "0x26D9B70", Offset = "0x26D9B70", VA = "0x26D9B70")]
	private void GetCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x600B78D")]
	[Address(RVA = "0x26D9AB8", Offset = "0x26D9AB8", VA = "0x26D9AB8")]
	private void SetShowDots(bool v)
	{
	}

	[Token(Token = "0x600B78E")]
	[Address(RVA = "0x26D9CFC", Offset = "0x26D9CFC", VA = "0x26D9CFC", Slot = "36")]
	public override void HighlightCurrent()
	{
	}

	[Token(Token = "0x600B78F")]
	[Address(RVA = "0x26D9D74", Offset = "0x26D9D74", VA = "0x26D9D74", Slot = "59")]
	public override void InitMallView()
	{
	}

	[Token(Token = "0x600B790")]
	[Address(RVA = "0x26DAADC", Offset = "0x26DAADC", VA = "0x26DAADC", Slot = "60")]
	public override void RefreshMallView()
	{
	}

	[Token(Token = "0x600B791")]
	[Address(RVA = "0x26D8178", Offset = "0x26D8178", VA = "0x26D8178")]
	private void RefreshRecommendInfo()
	{
	}

	[Token(Token = "0x600B792")]
	[Address(RVA = "0x26D9F24", Offset = "0x26D9F24", VA = "0x26D9F24")]
	private void UpdateTabs()
	{
	}

	[Token(Token = "0x600B793")]
	[Address(RVA = "0x26DAB68", Offset = "0x26DAB68", VA = "0x26DAB68")]
	protected void DiscountToggleAnim()
	{
	}

	[Token(Token = "0x600B794")]
	[Address(RVA = "0x26DAE3C", Offset = "0x26DAE3C", VA = "0x26DAE3C", Slot = "71")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B795")]
	[Address(RVA = "0x26DAF5C", Offset = "0x26DAF5C", VA = "0x26DAF5C", Slot = "72")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B796")]
	[Address(RVA = "0x26DAFDC", Offset = "0x26DAFDC", VA = "0x26DAFDC", Slot = "56")]
	protected override void ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B797")]
	[Address(RVA = "0x26DB528", Offset = "0x26DB528", VA = "0x26DB528", Slot = "40")]
	protected override void OnADToggleSelected()
	{
	}

	[Token(Token = "0x600B798")]
	[Address(RVA = "0x26DB8D4", Offset = "0x26DB8D4", VA = "0x26DB8D4", Slot = "42")]
	protected override void OnBundleToggleSelected()
	{
	}

	[Token(Token = "0x600B799")]
	[Address(RVA = "0x26DBA48", Offset = "0x26DBA48", VA = "0x26DBA48", Slot = "43")]
	protected override void OnAvatarToggleSelected()
	{
	}

	[Token(Token = "0x600B79A")]
	[Address(RVA = "0x26DBBBC", Offset = "0x26DBBBC", VA = "0x26DBBBC", Slot = "44")]
	protected override void OnCustomizeToggleSelected()
	{
	}

	[Token(Token = "0x600B79B")]
	[Address(RVA = "0x26DBE04", Offset = "0x26DBE04", VA = "0x26DBE04", Slot = "45")]
	protected override void OnPropsToggleSelected()
	{
	}

	[Token(Token = "0x600B79C")]
	[Address(RVA = "0x26DBF78", Offset = "0x26DBF78", VA = "0x26DBF78", Slot = "46")]
	protected override void OnCallSignToggleSelected()
	{
	}

	[Token(Token = "0x600B79D")]
	[Address(RVA = "0x26DC0EC", Offset = "0x26DC0EC", VA = "0x26DC0EC", Slot = "48")]
	protected override void OnPetToggleSelected()
	{
	}

	[Token(Token = "0x600B79E")]
	[Address(RVA = "0x26DC260", Offset = "0x26DC260", VA = "0x26DC260")]
	protected void OnDiscountToggleSelected()
	{
	}

	[Token(Token = "0x600B79F")]
	[Address(RVA = "0x26DC5D8", Offset = "0x26DC5D8", VA = "0x26DC5D8")]
	private void OnInstallmentToggleSelected()
	{
	}

	[Token(Token = "0x600B7A0")]
	[Address(RVA = "0x26DC8A0", Offset = "0x26DC8A0", VA = "0x26DC8A0", Slot = "62")]
	public override void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
	{
	}

	[Token(Token = "0x600B7A1")]
	[Address(RVA = "0x26D6FF8", Offset = "0x26D6FF8", VA = "0x26D6FF8")]
	private void OnAllClothToggleClick()
	{
	}

	[Token(Token = "0x600B7A2")]
	[Address(RVA = "0x26DCEA8", Offset = "0x26DCEA8", VA = "0x26DCEA8")]
	private void OnCommomClothToggleClick()
	{
	}

	[Token(Token = "0x600B7A3")]
	[Address(RVA = "0x26DD22C", Offset = "0x26DD22C", VA = "0x26DD22C")]
	private void OnMaleClothToggleClick()
	{
	}

	[Token(Token = "0x600B7A4")]
	[Address(RVA = "0x26DD3F8", Offset = "0x26DD3F8", VA = "0x26DD3F8")]
	private void OnFemaleClothToggleClick()
	{
	}

	[Token(Token = "0x600B7A5")]
	[Address(RVA = "0x26DD074", Offset = "0x26DD074", VA = "0x26DD074")]
	private void RefreshClothViewByGender(EClothGenderType genderType)
	{
	}

	[Token(Token = "0x600B7A6")]
	[Address(RVA = "0x26DD5C4", Offset = "0x26DD5C4", VA = "0x26DD5C4")]
	private List<StoreDesc> GenderSelectionList(EClothGenderType genderType)
	{
		return null;
	}

	[Token(Token = "0x600B7A7")]
	[Address(RVA = "0x26DD7B0", Offset = "0x26DD7B0", VA = "0x26DD7B0", Slot = "52")]
	protected override void RefreshCurrentTabView(UINavigationUtil.UINavigationMallTabType mallTabType)
	{
	}

	[Token(Token = "0x600B7A8")]
	[Address(RVA = "0x26DDB00", Offset = "0x26DDB00", VA = "0x26DDB00", Slot = "53")]
	public override void HideItemEffect()
	{
	}

	[Token(Token = "0x600B7A9")]
	[Address(RVA = "0x26DDB74", Offset = "0x26DDB74", VA = "0x26DDB74", Slot = "63")]
	public override void RefreshCurrentMallView(bool clickItem)
	{
	}

	[Token(Token = "0x600B7AA")]
	[Address(RVA = "0x26DDCC0", Offset = "0x26DDCC0", VA = "0x26DDCC0", Slot = "64")]
	public override UIEasyList GetCurrentMallEasyList()
	{
		return null;
	}

	[Token(Token = "0x600B7AB")]
	[Address(RVA = "0x26DDD84", Offset = "0x26DDD84", VA = "0x26DDD84")]
	private void OnGoToDiscountBtnClick()
	{
	}

	[Token(Token = "0x600B7AC")]
	[Address(RVA = "0x26DDE0C", Offset = "0x26DDE0C", VA = "0x26DDE0C", Slot = "69")]
	protected override void OnCommonWndFinish(object[] data)
	{
	}

	[Token(Token = "0x600B7AD")]
	[Address(RVA = "0x26DDEF4", Offset = "0x26DDEF4", VA = "0x26DDEF4")]
	private void ShowOfferPurchase()
	{
	}

	[Token(Token = "0x600B7AE")]
	public T OpenChild<T>(Transform parent) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x600B7AF")]
	[Address(RVA = "0x26DE084", Offset = "0x26DE084", VA = "0x26DE084", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B7B0")]
	[Address(RVA = "0x26DE340", Offset = "0x26DE340", VA = "0x26DE340", Slot = "67")]
	public override void ShowMall()
	{
	}

	[Token(Token = "0x600B7B1")]
	[Address(RVA = "0x26DE428", Offset = "0x26DE428", VA = "0x26DE428")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600B7B2")]
	[Address(RVA = "0x26DE434", Offset = "0x26DE434", VA = "0x26DE434")]
	private static bool _003COnSubToggleClick_003Em__1(SubTabInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x600B7B3")]
	[Address(RVA = "0x26DE474", Offset = "0x26DE474", VA = "0x26DE474")]
	private static bool _003COnADScrollViewMove_003Em__2(AdItemInfo n, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600B7B4")]
	[Address(RVA = "0x26DE484", Offset = "0x26DE484", VA = "0x26DE484")]
	private static bool _003CRefreshAdsView_003Em__3(AdItemInfo n, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600B7B5")]
	[Address(RVA = "0x26DE494", Offset = "0x26DE494", VA = "0x26DE494")]
	private static int _003CInitMallView_003Em__4(AdItemInfo a, AdItemInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600B7B6")]
	[Address(RVA = "0x26DE504", Offset = "0x26DE504", VA = "0x26DE504")]
	private static bool _003CRefreshRecommendInfo_003Em__5(StoreDesc item)
	{
		return default(bool);
	}

	[Token(Token = "0x600B7B7")]
	[Address(RVA = "0x26DE528", Offset = "0x26DE528", VA = "0x26DE528")]
	private static uint _003CUpdateTabs_003Em__6(UINavigationUtil.UINavigationMallTabType type)
	{
		return default(uint);
	}

	[Token(Token = "0x600B7B8")]
	[Address(RVA = "0x26DE52C", Offset = "0x26DE52C", VA = "0x26DE52C")]
	private void _003CUpdateTabs_003Em__7()
	{
	}

	[Token(Token = "0x600B7B9")]
	[Address(RVA = "0x26DE558", Offset = "0x26DE558", VA = "0x26DE558")]
	private int _003CUpdateTabs_003Em__8(uint x, uint y)
	{
		return default(int);
	}

	[Token(Token = "0x600B7BA")]
	[Address(RVA = "0x26DE638", Offset = "0x26DE638", VA = "0x26DE638")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B7BB")]
	[Address(RVA = "0x26DE640", Offset = "0x26DE640", VA = "0x26DE640")]
	public void _003C_003EiFixBaseProxy_InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B7BC")]
	[Address(RVA = "0x26DE648", Offset = "0x26DE648", VA = "0x26DE648")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B7BD")]
	[Address(RVA = "0x26DE650", Offset = "0x26DE650", VA = "0x26DE650")]
	public void _003C_003EiFixBaseProxy_OnSubToggleClick()
	{
	}

	[Token(Token = "0x600B7BE")]
	[Address(RVA = "0x26DE658", Offset = "0x26DE658", VA = "0x26DE658")]
	public void _003C_003EiFixBaseProxy_OnClothPreviewToggleClick()
	{
	}

	[Token(Token = "0x600B7BF")]
	[Address(RVA = "0x26DE660", Offset = "0x26DE660", VA = "0x26DE660")]
	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}

	[Token(Token = "0x600B7C0")]
	[Address(RVA = "0x26DE668", Offset = "0x26DE668", VA = "0x26DE668")]
	public void _003C_003EiFixBaseProxy_UnSelectItem(uint P0)
	{
	}

	[Token(Token = "0x600B7C1")]
	[Address(RVA = "0x26DE670", Offset = "0x26DE670", VA = "0x26DE670")]
	public bool _003C_003EiFixBaseProxy_CanFindStoreItem(uint P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600B7C2")]
	[Address(RVA = "0x26DE678", Offset = "0x26DE678", VA = "0x26DE678")]
	public void _003C_003EiFixBaseProxy_HighlightCurrent()
	{
	}

	[Token(Token = "0x600B7C3")]
	[Address(RVA = "0x26DE680", Offset = "0x26DE680", VA = "0x26DE680")]
	public void _003C_003EiFixBaseProxy_InitMallView()
	{
	}

	[Token(Token = "0x600B7C4")]
	[Address(RVA = "0x26DE688", Offset = "0x26DE688", VA = "0x26DE688")]
	public void _003C_003EiFixBaseProxy_RefreshMallView()
	{
	}

	[Token(Token = "0x600B7C5")]
	[Address(RVA = "0x26DE690", Offset = "0x26DE690", VA = "0x26DE690")]
	public void _003C_003EiFixBaseProxy_ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B7C6")]
	[Address(RVA = "0x26DE698", Offset = "0x26DE698", VA = "0x26DE698")]
	public void _003C_003EiFixBaseProxy_OnADToggleSelected()
	{
	}

	[Token(Token = "0x600B7C7")]
	[Address(RVA = "0x26DE6A0", Offset = "0x26DE6A0", VA = "0x26DE6A0")]
	public void _003C_003EiFixBaseProxy_OnBundleToggleSelected()
	{
	}

	[Token(Token = "0x600B7C8")]
	[Address(RVA = "0x26DE6A8", Offset = "0x26DE6A8", VA = "0x26DE6A8")]
	public void _003C_003EiFixBaseProxy_OnAvatarToggleSelected()
	{
	}

	[Token(Token = "0x600B7C9")]
	[Address(RVA = "0x26DE6B0", Offset = "0x26DE6B0", VA = "0x26DE6B0")]
	public void _003C_003EiFixBaseProxy_OnCustomizeToggleSelected()
	{
	}

	[Token(Token = "0x600B7CA")]
	[Address(RVA = "0x26DE6B8", Offset = "0x26DE6B8", VA = "0x26DE6B8")]
	public void _003C_003EiFixBaseProxy_OnPropsToggleSelected()
	{
	}

	[Token(Token = "0x600B7CB")]
	[Address(RVA = "0x26DE6C0", Offset = "0x26DE6C0", VA = "0x26DE6C0")]
	public void _003C_003EiFixBaseProxy_OnCallSignToggleSelected()
	{
	}

	[Token(Token = "0x600B7CC")]
	[Address(RVA = "0x26DE6C8", Offset = "0x26DE6C8", VA = "0x26DE6C8")]
	public void _003C_003EiFixBaseProxy_OnPetToggleSelected()
	{
	}

	[Token(Token = "0x600B7CD")]
	[Address(RVA = "0x26DE6D0", Offset = "0x26DE6D0", VA = "0x26DE6D0")]
	public void _003C_003EiFixBaseProxy_NavigationToItem(uint P0, uint P1, uint P2)
	{
	}

	[Token(Token = "0x600B7CE")]
	[Address(RVA = "0x26DE6F0", Offset = "0x26DE6F0", VA = "0x26DE6F0")]
	public void _003C_003EiFixBaseProxy_RefreshCurrentTabView(UINavigationUtil.UINavigationMallTabType P0)
	{
	}

	[Token(Token = "0x600B7CF")]
	[Address(RVA = "0x26DE6F8", Offset = "0x26DE6F8", VA = "0x26DE6F8")]
	public void _003C_003EiFixBaseProxy_HideItemEffect()
	{
	}

	[Token(Token = "0x600B7D0")]
	[Address(RVA = "0x26DE700", Offset = "0x26DE700", VA = "0x26DE700")]
	public UIEasyList _003C_003EiFixBaseProxy_GetCurrentMallEasyList()
	{
		return null;
	}

	[Token(Token = "0x600B7D1")]
	[Address(RVA = "0x26DE708", Offset = "0x26DE708", VA = "0x26DE708")]
	public void _003C_003EiFixBaseProxy_OnCommonWndFinish(object[] P0)
	{
	}

	[Token(Token = "0x600B7D2")]
	[Address(RVA = "0x26DE710", Offset = "0x26DE710", VA = "0x26DE710")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B7D3")]
	[Address(RVA = "0x26DE718", Offset = "0x26DE718", VA = "0x26DE718")]
	public void _003C_003EiFixBaseProxy_ShowMall()
	{
	}
}
