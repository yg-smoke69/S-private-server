using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200415D")]
public class UINavigationData
{
	[Token(Token = "0x401B6C4")]
	[FieldOffset(Offset = "0x8")]
	private string m_Title;

	[Token(Token = "0x401B6C5")]
	[FieldOffset(Offset = "0xC")]
	private bool m_ReuseCache;

	[Token(Token = "0x401B6C6")]
	[FieldOffset(Offset = "0x10")]
	private int m_NavIndex;

	[Token(Token = "0x401B6C7")]
	[FieldOffset(Offset = "0x14")]
	private Type m_ContentControllerType;

	[Token(Token = "0x401B6C8")]
	[FieldOffset(Offset = "0x18")]
	private bool m_HideTopBar;

	[Token(Token = "0x401B6C9")]
	[FieldOffset(Offset = "0x1C")]
	private List<object> m_WindowParam;

	[Token(Token = "0x401B6CA")]
	[FieldOffset(Offset = "0x20")]
	private bool m_ShowAvatarWindow;

	[Token(Token = "0x401B6CB")]
	[FieldOffset(Offset = "0x21")]
	private bool m_ShowAvatarPose;

	[Token(Token = "0x401B6CC")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_ChatBtnPosition;

	[Token(Token = "0x401B6CD")]
	[FieldOffset(Offset = "0x30")]
	private bool m_ShowChatBtn;

	[Token(Token = "0x401B6CE")]
	[FieldOffset(Offset = "0x31")]
	private bool m_EnableAdsBtn;

	[Token(Token = "0x401B6CF")]
	[FieldOffset(Offset = "0x32")]
	private bool m_ShowHelpBtn;

	[Token(Token = "0x401B6D0")]
	[FieldOffset(Offset = "0x33")]
	private bool _003CShowVoiceBtn_003Ek__BackingField;

	[Token(Token = "0x401B6D1")]
	[FieldOffset(Offset = "0x34")]
	private bool _003CShowSettingInNaviPage_003Ek__BackingField;

	[Token(Token = "0x401B6D2")]
	[FieldOffset(Offset = "0x35")]
	private bool m_ShowOpenAnim;

	[Token(Token = "0x401B6D3")]
	[FieldOffset(Offset = "0x36")]
	public bool CleanUnusedAssetsOnDestroy;

	[Token(Token = "0x401B6D4")]
	[FieldOffset(Offset = "0x37")]
	private bool m_OnlyShowTopRightBtnGroup;

	[Token(Token = "0x401B6D5")]
	[FieldOffset(Offset = "0x38")]
	public Type PreNavigationType;

	[Token(Token = "0x401B6D6")]
	[FieldOffset(Offset = "0x3C")]
	public bool ShowLobby2DObjects;

	[Token(Token = "0x401B6D7")]
	[FieldOffset(Offset = "0x3D")]
	public bool IsShowOptionDownloader;

	[Token(Token = "0x17001D62")]
	public string Title
	{
		[Token(Token = "0x601AB3A")]
		[Address(RVA = "0x2CAA118", Offset = "0x2CAA118", VA = "0x2CAA118")]
		get
		{
			return null;
		}
		[Token(Token = "0x601AB3B")]
		[Address(RVA = "0x2CAA120", Offset = "0x2CAA120", VA = "0x2CAA120")]
		set
		{
		}
	}

	[Token(Token = "0x17001D63")]
	public bool ReuseCache
	{
		[Token(Token = "0x601AB3C")]
		[Address(RVA = "0x2CAA128", Offset = "0x2CAA128", VA = "0x2CAA128")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB3D")]
		[Address(RVA = "0x2CAA130", Offset = "0x2CAA130", VA = "0x2CAA130")]
		set
		{
		}
	}

	[Token(Token = "0x17001D64")]
	public int NavIndex
	{
		[Token(Token = "0x601AB3E")]
		[Address(RVA = "0x2CAA138", Offset = "0x2CAA138", VA = "0x2CAA138")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601AB3F")]
		[Address(RVA = "0x2CAA140", Offset = "0x2CAA140", VA = "0x2CAA140")]
		set
		{
		}
	}

	[Token(Token = "0x17001D65")]
	public Type ContentControllerType
	{
		[Token(Token = "0x601AB40")]
		[Address(RVA = "0x2C97FFC", Offset = "0x2C97FFC", VA = "0x2C97FFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x601AB41")]
		[Address(RVA = "0x2CAA148", Offset = "0x2CAA148", VA = "0x2CAA148")]
		set
		{
		}
	}

	[Token(Token = "0x17001D66")]
	public bool HideTopBar
	{
		[Token(Token = "0x601AB42")]
		[Address(RVA = "0x2CAA150", Offset = "0x2CAA150", VA = "0x2CAA150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB43")]
		[Address(RVA = "0x2CAA158", Offset = "0x2CAA158", VA = "0x2CAA158")]
		set
		{
		}
	}

	[Token(Token = "0x17001D67")]
	public List<object> WindowParam
	{
		[Token(Token = "0x601AB44")]
		[Address(RVA = "0x2CAA160", Offset = "0x2CAA160", VA = "0x2CAA160")]
		get
		{
			return null;
		}
		[Token(Token = "0x601AB45")]
		[Address(RVA = "0x2CAA168", Offset = "0x2CAA168", VA = "0x2CAA168")]
		set
		{
		}
	}

	[Token(Token = "0x17001D68")]
	public bool ShowAvatarWindow
	{
		[Token(Token = "0x601AB46")]
		[Address(RVA = "0x2CAA170", Offset = "0x2CAA170", VA = "0x2CAA170")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB47")]
		[Address(RVA = "0x2CAA178", Offset = "0x2CAA178", VA = "0x2CAA178")]
		set
		{
		}
	}

	[Token(Token = "0x17001D69")]
	public bool ShowAvatarPose
	{
		[Token(Token = "0x601AB48")]
		[Address(RVA = "0x2CAA180", Offset = "0x2CAA180", VA = "0x2CAA180")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB49")]
		[Address(RVA = "0x2CAA188", Offset = "0x2CAA188", VA = "0x2CAA188")]
		set
		{
		}
	}

	[Token(Token = "0x17001D6A")]
	public Vector3 ChatBtnPosition
	{
		[Token(Token = "0x601AB4A")]
		[Address(RVA = "0x2CAA190", Offset = "0x2CAA190", VA = "0x2CAA190")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x601AB4B")]
		[Address(RVA = "0x2CAA1A4", Offset = "0x2CAA1A4", VA = "0x2CAA1A4")]
		set
		{
		}
	}

	[Token(Token = "0x17001D6B")]
	public bool ShowChatBtn
	{
		[Token(Token = "0x601AB4C")]
		[Address(RVA = "0x2CAA1B0", Offset = "0x2CAA1B0", VA = "0x2CAA1B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB4D")]
		[Address(RVA = "0x2CAA1B8", Offset = "0x2CAA1B8", VA = "0x2CAA1B8")]
		set
		{
		}
	}

	[Token(Token = "0x17001D6C")]
	public bool EnableAdsBtn
	{
		[Token(Token = "0x601AB4E")]
		[Address(RVA = "0x2CAA1C0", Offset = "0x2CAA1C0", VA = "0x2CAA1C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB4F")]
		[Address(RVA = "0x2CAA1C8", Offset = "0x2CAA1C8", VA = "0x2CAA1C8")]
		set
		{
		}
	}

	[Token(Token = "0x17001D6D")]
	public bool ShowHelpBtn
	{
		[Token(Token = "0x601AB50")]
		[Address(RVA = "0x2CAA1D0", Offset = "0x2CAA1D0", VA = "0x2CAA1D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB51")]
		[Address(RVA = "0x2CAA1D8", Offset = "0x2CAA1D8", VA = "0x2CAA1D8")]
		set
		{
		}
	}

	[Token(Token = "0x17001D6E")]
	public bool ShowVoiceBtn
	{
		[Token(Token = "0x601AB52")]
		[Address(RVA = "0x2CAA1E0", Offset = "0x2CAA1E0", VA = "0x2CAA1E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB53")]
		[Address(RVA = "0x2CAA1E8", Offset = "0x2CAA1E8", VA = "0x2CAA1E8")]
		set
		{
		}
	}

	[Token(Token = "0x17001D6F")]
	public bool ShowSettingInNaviPage
	{
		[Token(Token = "0x601AB54")]
		[Address(RVA = "0x2CAA1F0", Offset = "0x2CAA1F0", VA = "0x2CAA1F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB55")]
		[Address(RVA = "0x2CAA1F8", Offset = "0x2CAA1F8", VA = "0x2CAA1F8")]
		set
		{
		}
	}

	[Token(Token = "0x17001D70")]
	public bool ShowOpenAnim
	{
		[Token(Token = "0x601AB56")]
		[Address(RVA = "0x2CAA200", Offset = "0x2CAA200", VA = "0x2CAA200")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB57")]
		[Address(RVA = "0x2CAA208", Offset = "0x2CAA208", VA = "0x2CAA208")]
		set
		{
		}
	}

	[Token(Token = "0x17001D71")]
	public bool OnlyShowTopRightBtnGroup
	{
		[Token(Token = "0x601AB58")]
		[Address(RVA = "0x2CAA210", Offset = "0x2CAA210", VA = "0x2CAA210")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AB59")]
		[Address(RVA = "0x2CAA218", Offset = "0x2CAA218", VA = "0x2CAA218")]
		set
		{
		}
	}

	[Token(Token = "0x601AB38")]
	[Address(RVA = "0x2CA9EC0", Offset = "0x2CA9EC0", VA = "0x2CA9EC0")]
	public UINavigationData()
	{
	}

	[Token(Token = "0x601AB39")]
	[Address(RVA = "0x2CA9FE8", Offset = "0x2CA9FE8", VA = "0x2CA9FE8")]
	public UINavigationData(string customizeTitle)
	{
	}

	[Token(Token = "0x601AB5A")]
	[Address(RVA = "0x2CAA220", Offset = "0x2CAA220", VA = "0x2CAA220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
