using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002985")]
public class UIManualMapDebrisController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002986")]
	public enum MapType
	{
		[Token(Token = "0x400FFBE")]
		NONE = 0,
		[Token(Token = "0x400FFBF")]
		Bermuda = 1001,
		[Token(Token = "0x400FFC0")]
		Sonoran = 4001,
		[Token(Token = "0x400FFC1")]
		Paradise = 3001
	}

	[Token(Token = "0x400FFB2")]
	[FieldOffset(Offset = "0x28")]
	private MapType m_Type;

	[Token(Token = "0x400FFB3")]
	[FieldOffset(Offset = "0x2C")]
	private UIManualMapDebrisView m_View;

	[Token(Token = "0x400FFB4")]
	[FieldOffset(Offset = "0x30")]
	private List<ManualChallenge> m_Desc;

	[Token(Token = "0x400FFB5")]
	[FieldOffset(Offset = "0x34")]
	private List<ManualMapReward> m_MapRewardDataList;

	[Token(Token = "0x400FFB6")]
	[FieldOffset(Offset = "0x38")]
	private List<ManualMapData> m_UnlockMapDataList;

	[Token(Token = "0x400FFB7")]
	[FieldOffset(Offset = "0x3C")]
	private List<UISprite> m_SignList;

	[Token(Token = "0x400FFB8")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int m_MaxCircleCnt;

	[Token(Token = "0x400FFB9")]
	[FieldOffset(Offset = "0x40")]
	private uint[] m_RadiusArray;

	[Token(Token = "0x400FFBA")]
	[FieldOffset(Offset = "0x44")]
	private bool m_MapHasProcessed;

	[Token(Token = "0x400FFBB")]
	[FieldOffset(Offset = "0x48")]
	private UIScrollView m_LabelScrollView;

	[Token(Token = "0x400FFBC")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001261")]
	public MapType MapDebrisType
	{
		[Token(Token = "0x6010A94")]
		[Address(RVA = "0x2C2E8A0", Offset = "0x2C2E8A0", VA = "0x2C2E8A0")]
		get
		{
			return default(MapType);
		}
	}

	[Token(Token = "0x6010A93")]
	[Address(RVA = "0x2C2EB50", Offset = "0x2C2EB50", VA = "0x2C2EB50")]
	public UIManualMapDebrisController()
	{
	}

	[Token(Token = "0x6010A95")]
	[Address(RVA = "0x2C2ED00", Offset = "0x2C2ED00", VA = "0x2C2ED00")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010A96")]
	[Address(RVA = "0x2C2EDA4", Offset = "0x2C2EDA4", VA = "0x2C2EDA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010A97")]
	[Address(RVA = "0x2C2F2E4", Offset = "0x2C2F2E4", VA = "0x2C2F2E4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010A98")]
	[Address(RVA = "0x2C2F348", Offset = "0x2C2F348", VA = "0x2C2F348", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010A99")]
	[Address(RVA = "0x2C2EA8C", Offset = "0x2C2EA8C", VA = "0x2C2EA8C")]
	public void SetData(MapType type, UIManualMapDebrisData data)
	{
	}

	[Token(Token = "0x6010A9A")]
	[Address(RVA = "0x2C2F4EC", Offset = "0x2C2F4EC", VA = "0x2C2F4EC")]
	private void ProcessData(UIManualMapDebrisData data)
	{
	}

	[Token(Token = "0x6010A9B")]
	[Address(RVA = "0x2C2E8F8", Offset = "0x2C2E8F8", VA = "0x2C2E8F8")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x6010A9C")]
	[Address(RVA = "0x2C30A60", Offset = "0x2C30A60", VA = "0x2C30A60")]
	private bool CheckIsAllUnlock()
	{
		return default(bool);
	}

	[Token(Token = "0x6010A9D")]
	[Address(RVA = "0x2C30B60", Offset = "0x2C30B60", VA = "0x2C30B60")]
	private void RefreshAllUnlockView()
	{
	}

	[Token(Token = "0x6010A9E")]
	[Address(RVA = "0x2C30FB4", Offset = "0x2C30FB4", VA = "0x2C30FB4")]
	private void RefreshLockView()
	{
	}

	[Token(Token = "0x6010A9F")]
	[Address(RVA = "0x2C32A98", Offset = "0x2C32A98", VA = "0x2C32A98")]
	private void OnMapClick()
	{
	}

	[Token(Token = "0x6010AA0")]
	[Address(RVA = "0x2C32FC8", Offset = "0x2C32FC8", VA = "0x2C32FC8")]
	private void OnClickReward()
	{
	}

	[Token(Token = "0x6010AA1")]
	[Address(RVA = "0x2C330D4", Offset = "0x2C330D4", VA = "0x2C330D4")]
	private void ShowRewardPreview()
	{
	}

	[Token(Token = "0x6010AA2")]
	[Address(RVA = "0x2C337B8", Offset = "0x2C337B8", VA = "0x2C337B8")]
	private void OnGetRewardSuccess(object[] data)
	{
	}

	[Token(Token = "0x6010AA3")]
	[Address(RVA = "0x2C33690", Offset = "0x2C33690", VA = "0x2C33690")]
	private void RequestMapReward()
	{
	}

	[Token(Token = "0x6010AA4")]
	[Address(RVA = "0x2C2F6F8", Offset = "0x2C2F6F8", VA = "0x2C2F6F8")]
	private void InitSign(MapType type)
	{
	}

	[Token(Token = "0x6010AA5")]
	[Address(RVA = "0x2C313FC", Offset = "0x2C313FC", VA = "0x2C313FC")]
	private void RefreshRewardBtnView()
	{
	}

	[Token(Token = "0x6010AA6")]
	[Address(RVA = "0x2C318C8", Offset = "0x2C318C8", VA = "0x2C318C8")]
	private Texture CalMapTexture(ManualMapReward data)
	{
		return null;
	}

	[Token(Token = "0x6010AA7")]
	[Address(RVA = "0x2C32778", Offset = "0x2C32778", VA = "0x2C32778")]
	private void RefreshSign()
	{
	}

	[Token(Token = "0x6010AA8")]
	[Address(RVA = "0x2C33C14", Offset = "0x2C33C14", VA = "0x2C33C14", Slot = "31")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6010AAA")]
	[Address(RVA = "0x2C33D08", Offset = "0x2C33D08", VA = "0x2C33D08")]
	private bool _003CProcessData_003Em__0(ManualChallenge e)
	{
		return default(bool);
	}

	[Token(Token = "0x6010AAB")]
	[Address(RVA = "0x2C33D40", Offset = "0x2C33D40", VA = "0x2C33D40")]
	private bool _003CProcessData_003Em__1(ManualMapReward e)
	{
		return default(bool);
	}

	[Token(Token = "0x6010AAC")]
	[Address(RVA = "0x2C33D78", Offset = "0x2C33D78", VA = "0x2C33D78")]
	private bool _003CProcessData_003Em__2(ManualMapData e)
	{
		return default(bool);
	}

	[Token(Token = "0x6010AAD")]
	[Address(RVA = "0x2C33DB0", Offset = "0x2C33DB0", VA = "0x2C33DB0")]
	private static CommonRewardItemInfo _003COnGetRewardSuccess_003Em__3(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6010AAE")]
	[Address(RVA = "0x2C33DB8", Offset = "0x2C33DB8", VA = "0x2C33DB8")]
	private void _003COnGetRewardSuccess_003Em__4()
	{
	}

	[Token(Token = "0x6010AAF")]
	[Address(RVA = "0x2C33E24", Offset = "0x2C33E24", VA = "0x2C33E24")]
	private bool _003CRefreshRewardBtnView_003Em__5(proto.ManualMapReward e)
	{
		return default(bool);
	}

	[Token(Token = "0x6010AB0")]
	[Address(RVA = "0x2C33E5C", Offset = "0x2C33E5C", VA = "0x2C33E5C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010AB1")]
	[Address(RVA = "0x2C33E64", Offset = "0x2C33E64", VA = "0x2C33E64")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010AB2")]
	[Address(RVA = "0x2C33E6C", Offset = "0x2C33E6C", VA = "0x2C33E6C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
