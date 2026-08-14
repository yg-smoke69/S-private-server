using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.UGCUI;

[Token(Token = "0x20040FB")]
public class UGCHudPrefabRoot : UGCUIWidget
{
	[Token(Token = "0x401B4E3")]
	[FieldOffset(Offset = "0x40")]
	private int m_ScreenWidth;

	[Token(Token = "0x401B4E4")]
	[FieldOffset(Offset = "0x44")]
	private int m_ScreenHeight;

	[Token(Token = "0x401B4E5")]
	[FieldOffset(Offset = "0x48")]
	private uint m_MaxWidgetID;

	[Token(Token = "0x401B4E6")]
	private const int START_DEPTH = 3;

	[Token(Token = "0x401B4E7")]
	[FieldOffset(Offset = "0x4C")]
	private List<UGCHudWidget> m_WidgetList;

	[Token(Token = "0x17001D12")]
	public int ScreenWidth
	{
		[Token(Token = "0x601A858")]
		[Address(RVA = "0x324D53C", Offset = "0x324D53C", VA = "0x324D53C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601A859")]
		[Address(RVA = "0x324D544", Offset = "0x324D544", VA = "0x324D544")]
		set
		{
		}
	}

	[Token(Token = "0x17001D13")]
	public int ScreenHeight
	{
		[Token(Token = "0x601A85A")]
		[Address(RVA = "0x324D55C", Offset = "0x324D55C", VA = "0x324D55C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601A85B")]
		[Address(RVA = "0x324D564", Offset = "0x324D564", VA = "0x324D564")]
		set
		{
		}
	}

	[Token(Token = "0x17001D14")]
	public uint MaxWidgetID
	{
		[Token(Token = "0x601A85C")]
		[Address(RVA = "0x324D57C", Offset = "0x324D57C", VA = "0x324D57C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001D15")]
	public int StartDepth
	{
		[Token(Token = "0x601A85D")]
		[Address(RVA = "0x324D650", Offset = "0x324D650", VA = "0x324D650")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x601A857")]
	[Address(RVA = "0x324D484", Offset = "0x324D484", VA = "0x324D484")]
	public UGCHudPrefabRoot()
	{
	}

	[Token(Token = "0x601A85E")]
	[Address(RVA = "0x324D658", Offset = "0x324D658", VA = "0x324D658")]
	public static UGCHudPrefabRoot GetOrAdd(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x601A85F")]
	[Address(RVA = "0x324D82C", Offset = "0x324D82C", VA = "0x324D82C")]
	public void SetScreenSize(int width, int height)
	{
	}

	[Token(Token = "0x601A860")]
	[Address(RVA = "0x324D960", Offset = "0x324D960", VA = "0x324D960")]
	public void UpdateChildrenAlignment()
	{
	}

	[Token(Token = "0x601A861")]
	[Address(RVA = "0x324DAC8", Offset = "0x324DAC8", VA = "0x324DAC8")]
	public void UpdateHierarchy()
	{
	}

	[Token(Token = "0x601A862")]
	[Address(RVA = "0x324DAD8", Offset = "0x324DAD8", VA = "0x324DAD8")]
	public int GetWidgetCount()
	{
		return default(int);
	}

	[Token(Token = "0x601A863")]
	[Address(RVA = "0x324D7F4", Offset = "0x324D7F4", VA = "0x324D7F4")]
	protected internal void Init()
	{
	}
}
