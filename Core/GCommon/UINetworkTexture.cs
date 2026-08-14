using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200415E")]
public class UINetworkTexture : MonoBehaviour
{
	[Token(Token = "0x401B6D8")]
	[FieldOffset(Offset = "0xC")]
	public UITexture m_TargetTexture;

	[Token(Token = "0x401B6D9")]
	[FieldOffset(Offset = "0x10")]
	public Texture m_DefaultTexture;

	[Token(Token = "0x401B6DA")]
	[FieldOffset(Offset = "0x14")]
	private bool m_ShowLoadingState;

	[Token(Token = "0x401B6DB")]
	[FieldOffset(Offset = "0x15")]
	private bool m_WaitingTimeState;

	[Token(Token = "0x401B6DC")]
	[FieldOffset(Offset = "0x18")]
	private float m_WaitingTime;

	[Token(Token = "0x401B6DD")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject m_CommonLoadingGO;

	[Token(Token = "0x401B6DE")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsMakePerfect;

	[Token(Token = "0x401B6DF")]
	[FieldOffset(Offset = "0x21")]
	private bool m_needCache;

	[Token(Token = "0x401B6E0")]
	[FieldOffset(Offset = "0x22")]
	private bool m_isReadable;

	[Token(Token = "0x401B6E1")]
	[FieldOffset(Offset = "0x24")]
	private string m_CurrentDownloadURL;

	[Token(Token = "0x401B6E2")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsUseOriginalURL;

	[Token(Token = "0x401B6E3")]
	[FieldOffset(Offset = "0x29")]
	private bool m_IsAwaked;

	[Token(Token = "0x401B6E4")]
	[FieldOffset(Offset = "0x2A")]
	private bool m_IsPendingDownload;

	[Token(Token = "0x401B6E5")]
	[FieldOffset(Offset = "0x2C")]
	private Action m_SuccessCallBack;

	[Token(Token = "0x601AB5B")]
	[Address(RVA = "0x2CAA328", Offset = "0x2CAA328", VA = "0x2CAA328")]
	public UINetworkTexture()
	{
	}

	[Token(Token = "0x601AB5C")]
	[Address(RVA = "0x2CAA3D0", Offset = "0x2CAA3D0", VA = "0x2CAA3D0")]
	public static implicit operator UITexture(UINetworkTexture network_texture)
	{
		return null;
	}

	[Token(Token = "0x601AB5D")]
	[Address(RVA = "0x2CAA3F4", Offset = "0x2CAA3F4", VA = "0x2CAA3F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AB5E")]
	[Address(RVA = "0x2CAA4E0", Offset = "0x2CAA4E0", VA = "0x2CAA4E0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601AB5F")]
	[Address(RVA = "0x2CAA620", Offset = "0x2CAA620", VA = "0x2CAA620")]
	public void UnRegisterCallBack()
	{
	}

	[Token(Token = "0x601AB60")]
	[Address(RVA = "0x2CAA62C", Offset = "0x2CAA62C", VA = "0x2CAA62C", Slot = "4")]
	public virtual void SetAsyncImageFromUrl(string url, bool isMakePerfect = false, bool needCache = true, [Optional] Action successCallBack, bool useOriginalUrl = false, bool isReadable = false, bool useDefaultTexture = true, bool showLoading = true)
	{
	}

	[Token(Token = "0x601AB61")]
	[Address(RVA = "0x2CAAB4C", Offset = "0x2CAAB4C", VA = "0x2CAAB4C")]
	public void StopDownload(bool removeCache = true)
	{
	}

	[Token(Token = "0x601AB62")]
	[Address(RVA = "0x2CAACE0", Offset = "0x2CAACE0", VA = "0x2CAACE0", Slot = "5")]
	public virtual void OnDowloadFinished(Texture texture)
	{
	}

	[Token(Token = "0x601AB63")]
	[Address(RVA = "0x2CAAAF4", Offset = "0x2CAAAF4", VA = "0x2CAAAF4")]
	private void ShowCommonLoading(bool show = true)
	{
	}

	[Token(Token = "0x601AB64")]
	[Address(RVA = "0x2CAAF14", Offset = "0x2CAAF14", VA = "0x2CAAF14")]
	private void CommonLoadingActive(bool isActive)
	{
	}

	[Token(Token = "0x601AB65")]
	[Address(RVA = "0x2CAB834", Offset = "0x2CAB834", VA = "0x2CAB834")]
	private void Update()
	{
	}
}
