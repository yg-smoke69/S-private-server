using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002602")]
public class UIEmoteDressUpExchangeItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400EACA")]
	[FieldOffset(Offset = "0x28")]
	private UIEmoteDressUpExchangeItemView m_View;

	[Token(Token = "0x400EACB")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelDressUp m_Model;

	[Token(Token = "0x400EACC")]
	[FieldOffset(Offset = "0x30")]
	private DressUpCardState m_state;

	[Token(Token = "0x400EACD")]
	[FieldOffset(Offset = "0x34")]
	private uint m_Slotid;

	[Token(Token = "0x400EACE")]
	[FieldOffset(Offset = "0x38")]
	private ulong mytime;

	[Token(Token = "0x400EACF")]
	[FieldOffset(Offset = "0x40")]
	private UINewDownloadInfoController m_Downloader;

	[Token(Token = "0x400EAD0")]
	[FieldOffset(Offset = "0x44")]
	private GameObject m_DesgarMask;

	[Token(Token = "0x600E0AA")]
	[Address(RVA = "0x19D0DB8", Offset = "0x19D0DB8", VA = "0x19D0DB8")]
	public UIEmoteDressUpExchangeItemController()
	{
	}

	[Token(Token = "0x600E0AB")]
	[Address(RVA = "0x19D0E3C", Offset = "0x19D0E3C", VA = "0x19D0E3C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E0AC")]
	[Address(RVA = "0x19D105C", Offset = "0x19D105C", VA = "0x19D105C")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600E0AD")]
	[Address(RVA = "0x19D1A24", Offset = "0x19D1A24", VA = "0x19D1A24")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E0AE")]
	[Address(RVA = "0x19D1AC8", Offset = "0x19D1AC8", VA = "0x19D1AC8")]
	public void UpdateDressUpItemDownloadStatus(Transform desgarTrans, [Optional] GameObject desgarMask)
	{
	}

	[Token(Token = "0x600E0AF")]
	[Address(RVA = "0x19D1EC0", Offset = "0x19D1EC0", VA = "0x19D1EC0")]
	public void SetUIData(uint index)
	{
	}

	[Token(Token = "0x600E0B0")]
	[Address(RVA = "0x19D2408", Offset = "0x19D2408", VA = "0x19D2408", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E0B1")]
	[Address(RVA = "0x19D2544", Offset = "0x19D2544", VA = "0x19D2544", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E0B2")]
	[Address(RVA = "0x19D25D8", Offset = "0x19D25D8", VA = "0x19D25D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
