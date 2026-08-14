using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20025B6")]
public class UICreateRoomMapItem : MonoBehaviour
{
	[Token(Token = "0x400E963")]
	[FieldOffset(Offset = "0xC")]
	public UISprite m_MapImg;

	[Token(Token = "0x400E964")]
	[FieldOffset(Offset = "0x10")]
	public UINetworkTexture m_CDNTexutre;

	[Token(Token = "0x400E965")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton m_MapToggle;

	[Token(Token = "0x400E966")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_LockBG;

	[Token(Token = "0x400E967")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel m_MapNameTxt;

	[Token(Token = "0x400E968")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_DownloadingIcon;

	[Token(Token = "0x400E969")]
	[FieldOffset(Offset = "0x24")]
	public UINewDownloadInfoController m_Downloader;

	[Token(Token = "0x400E96A")]
	[FieldOffset(Offset = "0x28")]
	private uint m_MapID;

	[Token(Token = "0x400E96B")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_GameMode;

	[Token(Token = "0x400E96C")]
	[FieldOffset(Offset = "0x30")]
	private string m_MapName;

	[Token(Token = "0x400E96D")]
	[FieldOffset(Offset = "0x34")]
	public SelectMapItemDelegate fnSelectMapItem;

	[Token(Token = "0x1700114D")]
	public uint MapID
	{
		[Token(Token = "0x600DD5D")]
		[Address(RVA = "0x2731260", Offset = "0x2731260", VA = "0x2731260")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700114E")]
	public uint GameMode
	{
		[Token(Token = "0x600DD5E")]
		[Address(RVA = "0x27312B8", Offset = "0x27312B8", VA = "0x27312B8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700114F")]
	public string MapName
	{
		[Token(Token = "0x600DD5F")]
		[Address(RVA = "0x2731310", Offset = "0x2731310", VA = "0x2731310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600DD5C")]
	[Address(RVA = "0x27311C0", Offset = "0x27311C0", VA = "0x27311C0")]
	public UICreateRoomMapItem()
	{
	}

	[Token(Token = "0x600DD60")]
	[Address(RVA = "0x2731368", Offset = "0x2731368", VA = "0x2731368")]
	public void Start()
	{
	}

	[Token(Token = "0x600DD61")]
	[Address(RVA = "0x2731488", Offset = "0x2731488", VA = "0x2731488")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600DD62")]
	[Address(RVA = "0x2731510", Offset = "0x2731510", VA = "0x2731510")]
	public void SetData(uint mapID, uint gameMode)
	{
	}

	[Token(Token = "0x600DD63")]
	[Address(RVA = "0x2731850", Offset = "0x2731850", VA = "0x2731850")]
	private void Update()
	{
	}

	[Token(Token = "0x600DD64")]
	[Address(RVA = "0x27316C8", Offset = "0x27316C8", VA = "0x27316C8")]
	public void ClearData()
	{
	}

	[Token(Token = "0x600DD65")]
	[Address(RVA = "0x27318A4", Offset = "0x27318A4", VA = "0x27318A4")]
	public void OnMapToggleSelect()
	{
	}

	[Token(Token = "0x600DD66")]
	[Address(RVA = "0x2731974", Offset = "0x2731974", VA = "0x2731974")]
	public void TryDownLoadMapRes()
	{
	}
}
