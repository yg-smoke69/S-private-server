using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200269E")]
internal class UIGameModeBaseItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x200269F")]
	private sealed class _003CSetOpenDetailsUI_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400EE41")]
		[FieldOffset(Offset = "0x8")]
		internal UIGameModeBaseItemController _0024this;

		[Token(Token = "0x400EE42")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400EE43")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400EE44")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001193")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600E85D")]
			[Address(RVA = "0x246652C", Offset = "0x246652C", VA = "0x246652C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001194")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600E85E")]
			[Address(RVA = "0x2466534", Offset = "0x2466534", VA = "0x2466534", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600E85B")]
		[Address(RVA = "0x2463E98", Offset = "0x2463E98", VA = "0x2463E98")]
		public _003CSetOpenDetailsUI_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600E85C")]
		[Address(RVA = "0x2466218", Offset = "0x2466218", VA = "0x2466218", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600E85F")]
		[Address(RVA = "0x246653C", Offset = "0x246653C", VA = "0x246653C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600E860")]
		[Address(RVA = "0x2466550", Offset = "0x2466550", VA = "0x2466550", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20026A0")]
	private sealed class _003COnHLDefaultMap_003Ec__AnonStorey1
	{
		[Token(Token = "0x400EE45")]
		[FieldOffset(Offset = "0x8")]
		internal MapModeData mapdata;

		[Token(Token = "0x600E861")]
		[Address(RVA = "0x2465754", Offset = "0x2465754", VA = "0x2465754")]
		public _003COnHLDefaultMap_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600E862")]
		[Address(RVA = "0x24661D4", Offset = "0x24661D4", VA = "0x24661D4")]
		internal bool _003C_003Em__0(MapModeData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400EE30")]
	[FieldOffset(Offset = "0x28")]
	public UIGameModeMainController GameModeMainController;

	[Token(Token = "0x400EE31")]
	[FieldOffset(Offset = "0x2C")]
	private List<MapModeData> m_MapDataList;

	[Token(Token = "0x400EE32")]
	[FieldOffset(Offset = "0x30")]
	private MapModeData m_SelectedMapData;

	[Token(Token = "0x400EE33")]
	[FieldOffset(Offset = "0x34")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400EE34")]
	[FieldOffset(Offset = "0x38")]
	protected UIGameModeBaseItemView m_View;

	[Token(Token = "0x400EE35")]
	[FieldOffset(Offset = "0x3C")]
	private EGameModeUIType m_UIType;

	[Token(Token = "0x400EE36")]
	[FieldOffset(Offset = "0x40")]
	private UINewDownloadInfoController m_Downloader;

	[Token(Token = "0x400EE37")]
	[FieldOffset(Offset = "0x44")]
	private bool m_CanOpenMode;

	[Token(Token = "0x400EE38")]
	[FieldOffset(Offset = "0x48")]
	protected int m_depth;

	[Token(Token = "0x400EE39")]
	[FieldOffset(Offset = "0x4C")]
	protected List<ResourceID> m_NeedDownloadRes;

	[Token(Token = "0x400EE3A")]
	[FieldOffset(Offset = "0x50")]
	private uint m_DelayCall;

	[Token(Token = "0x400EE3B")]
	[FieldOffset(Offset = "0x54")]
	private int m_CurSelectedIndex;

	[Token(Token = "0x400EE3C")]
	[FieldOffset(Offset = "0x58")]
	private UIGameModeOpenDetailsController m_DetailController;

	[Token(Token = "0x400EE3D")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelOptionalDownload m_ModelDownload;

	[Token(Token = "0x400EE3E")]
	[FieldOffset(Offset = "0x60")]
	private bool m_CDNTextureDirty;

	[Token(Token = "0x400EE3F")]
	[FieldOffset(Offset = "0x64")]
	public ResDownloadType m_ResType;

	[Token(Token = "0x400EE40")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<MapModeData> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x600E838")]
	[Address(RVA = "0x2460E54", Offset = "0x2460E54", VA = "0x2460E54")]
	public UIGameModeBaseItemController()
	{
	}

	[Token(Token = "0x600E839")]
	[Address(RVA = "0x2460F50", Offset = "0x2460F50", VA = "0x2460F50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E83A")]
	[Address(RVA = "0x2460FF8", Offset = "0x2460FF8", VA = "0x2460FF8")]
	public UIWidget GetWidget()
	{
		return null;
	}

	[Token(Token = "0x600E83B")]
	[Address(RVA = "0x2461068", Offset = "0x2461068", VA = "0x2461068")]
	public UIButton GetGuideButton()
	{
		return null;
	}

	[Token(Token = "0x600E83C")]
	[Address(RVA = "0x24610D8", Offset = "0x24610D8", VA = "0x24610D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E83D")]
	[Address(RVA = "0x24616B8", Offset = "0x24616B8", VA = "0x24616B8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E83E")]
	[Address(RVA = "0x2461A2C", Offset = "0x2461A2C", VA = "0x2461A2C")]
	public void SetUIData(uint matchMode, List<MapModeData> dataList, EGameModeUIType gameModeUiType)
	{
	}

	[Token(Token = "0x600E83F")]
	[Address(RVA = "0x2462538", Offset = "0x2462538", VA = "0x2462538")]
	private void RefreshAvailableMap()
	{
	}

	[Token(Token = "0x600E840")]
	[Address(RVA = "0x2462E48", Offset = "0x2462E48", VA = "0x2462E48")]
	private void updateDownloadList()
	{
	}

	[Token(Token = "0x600E841")]
	[Address(RVA = "0x2462A60", Offset = "0x2462A60", VA = "0x2462A60")]
	private void SetMapModeUI(MapModeData mapModeData)
	{
	}

	[Token(Token = "0x600E842")]
	[Address(RVA = "0x2463A20", Offset = "0x2463A20", VA = "0x2463A20")]
	private void ClipCDNTexture()
	{
	}

	[Token(Token = "0x600E843")]
	[Address(RVA = "0x2463954", Offset = "0x2463954", VA = "0x2463954")]
	private IEnumerator SetOpenDetailsUI()
	{
		return null;
	}

	[Token(Token = "0x600E844")]
	[Address(RVA = "0x24632B0", Offset = "0x24632B0", VA = "0x24632B0")]
	private bool LoadLiveEffects(MapModeData mapModeData)
	{
		return default(bool);
	}

	[Token(Token = "0x600E845")]
	[Address(RVA = "0x2463EA0", Offset = "0x2463EA0", VA = "0x2463EA0", Slot = "33")]
	public virtual void OnModeBtnClick()
	{
	}

	[Token(Token = "0x600E846")]
	[Address(RVA = "0x2464388", Offset = "0x2464388", VA = "0x2464388")]
	private bool CheckMapCanPick(MapModeData mapData)
	{
		return default(bool);
	}

	[Token(Token = "0x600E847")]
	[Address(RVA = "0x2464668", Offset = "0x2464668", VA = "0x2464668")]
	private void TryDownloadMapRes()
	{
	}

	[Token(Token = "0x600E848")]
	[Address(RVA = "0x2464CAC", Offset = "0x2464CAC", VA = "0x2464CAC")]
	private void OnMapDownloadSelectConfirm(int selectIndex)
	{
	}

	[Token(Token = "0x600E849")]
	[Address(RVA = "0x2464F00", Offset = "0x2464F00", VA = "0x2464F00")]
	public int SortId()
	{
		return default(int);
	}

	[Token(Token = "0x600E84A")]
	[Address(RVA = "0x2465018", Offset = "0x2465018", VA = "0x2465018")]
	public void ClickSuccess()
	{
	}

	[Token(Token = "0x600E84B")]
	[Address(RVA = "0x246506C", Offset = "0x246506C", VA = "0x246506C")]
	public void ResetTween()
	{
	}

	[Token(Token = "0x600E84C")]
	[Address(RVA = "0x24650C0", Offset = "0x24650C0", VA = "0x24650C0")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600E84D")]
	[Address(RVA = "0x2465120", Offset = "0x2465120", VA = "0x2465120")]
	private void OnChooseMapSuccess(object[] data)
	{
	}

	[Token(Token = "0x600E84E")]
	[Address(RVA = "0x24652C0", Offset = "0x24652C0", VA = "0x24652C0")]
	private void OnMapPickWndConfirm(object[] data)
	{
	}

	[Token(Token = "0x600E84F")]
	[Address(RVA = "0x2465428", Offset = "0x2465428", VA = "0x2465428")]
	private void OnHLDefaultMap(object[] data)
	{
	}

	[Token(Token = "0x600E850")]
	[Address(RVA = "0x246575C", Offset = "0x246575C", VA = "0x246575C")]
	public UIToggleButton GetModeToggleButton()
	{
		return null;
	}

	[Token(Token = "0x600E851")]
	[Address(RVA = "0x24657CC", Offset = "0x24657CC", VA = "0x24657CC")]
	public int GetItemWidth()
	{
		return default(int);
	}

	[Token(Token = "0x600E852")]
	[Address(RVA = "0x2465858", Offset = "0x2465858", VA = "0x2465858")]
	private void MapPanelVisibilityChanged(object[] data)
	{
	}

	[Token(Token = "0x600E853")]
	[Address(RVA = "0x2465960", Offset = "0x2465960", VA = "0x2465960", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E854")]
	[Address(RVA = "0x2465B94", Offset = "0x2465B94", VA = "0x2465B94", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E855")]
	[Address(RVA = "0x2462330", Offset = "0x2462330", VA = "0x2462330")]
	private bool IsPinnedClassicMode(MapModeData mapModeData)
	{
		return default(bool);
	}

	[Token(Token = "0x600E856")]
	[Address(RVA = "0x2465C28", Offset = "0x2465C28", VA = "0x2465C28")]
	public void SetSelectedMapDataByIndex(int index)
	{
	}

	[Token(Token = "0x600E857")]
	[Address(RVA = "0x2465D48", Offset = "0x2465D48", VA = "0x2465D48")]
	public void SetCSGuideTip()
	{
	}

	[Token(Token = "0x600E858")]
	[Address(RVA = "0x24660C4", Offset = "0x24660C4", VA = "0x24660C4")]
	private void _003COnModeBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x600E859")]
	[Address(RVA = "0x24661C4", Offset = "0x24661C4", VA = "0x24661C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E85A")]
	[Address(RVA = "0x24661CC", Offset = "0x24661CC", VA = "0x24661CC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
