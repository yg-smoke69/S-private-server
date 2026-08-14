using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20027F2")]
internal class UIHudPetAnimLobbyController : UIBaseController, _Attribute
{
	[Token(Token = "0x20027F3")]
	private sealed class _003CInitBtn_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F687")]
		[FieldOffset(Offset = "0x8")]
		internal PetActionData d;

		[Token(Token = "0x400F688")]
		[FieldOffset(Offset = "0xC")]
		internal int slotId;

		[Token(Token = "0x400F689")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudPetAnimLobbyController _0024this;

		[Token(Token = "0x600F80B")]
		[Address(RVA = "0x184C168", Offset = "0x184C168", VA = "0x184C168")]
		public _003CInitBtn_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600F80C")]
		[Address(RVA = "0x184CBE4", Offset = "0x184CBE4", VA = "0x184CBE4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400F67F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPetAnimView m_View;

	[Token(Token = "0x400F680")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelOptionalDownload m_ModelOptionalDownload;

	[Token(Token = "0x400F681")]
	[FieldOffset(Offset = "0x30")]
	private List<UINewDownloadInfoController> m_DownloaderList;

	[Token(Token = "0x400F682")]
	[FieldOffset(Offset = "0x34")]
	private List<ResourceID> m_NeedDownloadResList;

	[Token(Token = "0x400F683")]
	[FieldOffset(Offset = "0x38")]
	private PetInfo m_CurrentSelectPetInfo;

	[Token(Token = "0x400F684")]
	[FieldOffset(Offset = "0x3C")]
	private GameObject[] m_DesgarsMask;

	[Token(Token = "0x400F685")]
	[FieldOffset(Offset = "0x40")]
	private int m_AnimCnt;

	[Token(Token = "0x400F686")]
	[FieldOffset(Offset = "0x44")]
	private bool m_HasAnims;

	[Token(Token = "0x600F7FB")]
	[Address(RVA = "0x1849EB0", Offset = "0x1849EB0", VA = "0x1849EB0")]
	public UIHudPetAnimLobbyController()
	{
	}

	[Token(Token = "0x600F7FC")]
	[Address(RVA = "0x184A00C", Offset = "0x184A00C", VA = "0x184A00C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F7FD")]
	[Address(RVA = "0x184A0B4", Offset = "0x184A0B4", VA = "0x184A0B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F7FE")]
	[Address(RVA = "0x184A2D4", Offset = "0x184A2D4", VA = "0x184A2D4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F7FF")]
	[Address(RVA = "0x184A338", Offset = "0x184A338", VA = "0x184A338")]
	public void InitBtns(List<PetActionData> anims)
	{
	}

	[Token(Token = "0x600F800")]
	[Address(RVA = "0x184BD10", Offset = "0x184BD10", VA = "0x184BD10")]
	public void UpdateCurrentSelectPetInfo(PetInfo info)
	{
	}

	[Token(Token = "0x600F801")]
	[Address(RVA = "0x184B294", Offset = "0x184B294", VA = "0x184B294")]
	public void UpdateNeedDownloadResList()
	{
	}

	[Token(Token = "0x600F802")]
	[Address(RVA = "0x184B6F0", Offset = "0x184B6F0", VA = "0x184B6F0")]
	public void UpdateDownloaderList()
	{
	}

	[Token(Token = "0x600F803")]
	[Address(RVA = "0x184BD7C", Offset = "0x184BD7C", VA = "0x184BD7C")]
	public List<ResourceID> GetPetDownLoadRes(PetInfo petInfo)
	{
		return null;
	}

	[Token(Token = "0x600F804")]
	[Address(RVA = "0x184B304", Offset = "0x184B304", VA = "0x184B304")]
	private void InitBtn(UIButton btn, UISprite sprite, PetActionData d, int slotId)
	{
	}

	[Token(Token = "0x600F805")]
	[Address(RVA = "0x184C170", Offset = "0x184C170", VA = "0x184C170")]
	public void HidePanel()
	{
	}

	[Token(Token = "0x600F806")]
	[Address(RVA = "0x184C27C", Offset = "0x184C27C", VA = "0x184C27C")]
	private void OnClickAnim(PetActionData d, int slotId)
	{
	}

	[Token(Token = "0x600F807")]
	[Address(RVA = "0x184C9B4", Offset = "0x184C9B4", VA = "0x184C9B4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F808")]
	[Address(RVA = "0x184CB40", Offset = "0x184CB40", VA = "0x184CB40", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F809")]
	[Address(RVA = "0x184CBD4", Offset = "0x184CBD4", VA = "0x184CBD4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F80A")]
	[Address(RVA = "0x184CBDC", Offset = "0x184CBDC", VA = "0x184CBDC")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
