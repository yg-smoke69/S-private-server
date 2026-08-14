using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200213E")]
public class UILobbyVehicleDisplayItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400D071")]
	[FieldOffset(Offset = "0x38")]
	private UILobbyVehicleDisplayItemView m_View;

	[Token(Token = "0x400D072")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelVehicleDisplay m_Model;

	[Token(Token = "0x400D073")]
	[FieldOffset(Offset = "0x40")]
	private UIModelOptionalDownload m_optionalDownloadModel;

	[Token(Token = "0x400D074")]
	[FieldOffset(Offset = "0x44")]
	private VehicleSkinBaseInfo m_Info;

	[Token(Token = "0x400D075")]
	[FieldOffset(Offset = "0x48")]
	private UINewDownloadInfoController m_Downloader;

	[Token(Token = "0x400D076")]
	[FieldOffset(Offset = "0x4C")]
	private List<ResourceID> m_NeedDownloadList;

	[Token(Token = "0x600AEAF")]
	[Address(RVA = "0x1CBEA34", Offset = "0x1CBEA34", VA = "0x1CBEA34")]
	public UILobbyVehicleDisplayItemController()
	{
	}

	[Token(Token = "0x600AEB0")]
	[Address(RVA = "0x1CBEAC0", Offset = "0x1CBEAC0", VA = "0x1CBEAC0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AEB1")]
	[Address(RVA = "0x1CBEB64", Offset = "0x1CBEB64", VA = "0x1CBEB64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AEB2")]
	[Address(RVA = "0x1CBEECC", Offset = "0x1CBEECC", VA = "0x1CBEECC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600AEB3")]
	[Address(RVA = "0x1CBFA54", Offset = "0x1CBFA54", VA = "0x1CBFA54")]
	private void RefreshDownloadState(bool isAbReady)
	{
	}

	[Token(Token = "0x600AEB4")]
	[Address(RVA = "0x1CBFB78", Offset = "0x1CBFB78", VA = "0x1CBFB78", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AEB5")]
	[Address(RVA = "0x1CBFCBC", Offset = "0x1CBFCBC", VA = "0x1CBFCBC", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AEB6")]
	[Address(RVA = "0x1CBF534", Offset = "0x1CBF534", VA = "0x1CBF534")]
	private void SetQualityBG(uint quality)
	{
	}

	[Token(Token = "0x600AEB7")]
	[Address(RVA = "0x1CBFD50", Offset = "0x1CBFD50", VA = "0x1CBFD50")]
	private void OnButtonClicked()
	{
	}

	[Token(Token = "0x600AEB8")]
	[Address(RVA = "0x1CBFF50", Offset = "0x1CBFF50", VA = "0x1CBFF50", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600AEB9")]
	[Address(RVA = "0x1CC02B8", Offset = "0x1CC02B8", VA = "0x1CC02B8", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600AEBA")]
	[Address(RVA = "0x1CC0354", Offset = "0x1CC0354", VA = "0x1CC0354")]
	private void RemoveVehicle(object[] data)
	{
	}

	[Token(Token = "0x600AEBB")]
	[Address(RVA = "0x1CC03C8", Offset = "0x1CC03C8", VA = "0x1CC03C8")]
	private void ChangeVehicle(object[] data)
	{
	}

	[Token(Token = "0x600AEBC")]
	[Address(RVA = "0x1CC05CC", Offset = "0x1CC05CC", VA = "0x1CC05CC")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x600AEBD")]
	[Address(RVA = "0x1CC0770", Offset = "0x1CC0770", VA = "0x1CC0770")]
	private void _003CChangeVehicle_003Em__1()
	{
	}

	[Token(Token = "0x600AEBE")]
	[Address(RVA = "0x1CC0904", Offset = "0x1CC0904", VA = "0x1CC0904")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AEBF")]
	[Address(RVA = "0x1CC090C", Offset = "0x1CC090C", VA = "0x1CC090C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600AEC0")]
	[Address(RVA = "0x1CC0914", Offset = "0x1CC0914", VA = "0x1CC0914")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
