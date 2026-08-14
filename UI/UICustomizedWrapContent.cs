using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20025BF")]
public class UICustomizedWrapContent : MonoBehaviour
{
	[Token(Token = "0x20025C0")]
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	[Token(Token = "0x400E992")]
	[FieldOffset(Offset = "0xC")]
	public int itemSize;

	[Token(Token = "0x400E993")]
	[FieldOffset(Offset = "0x10")]
	public bool cullContent;

	[Token(Token = "0x400E994")]
	[FieldOffset(Offset = "0x14")]
	public int minIndex;

	[Token(Token = "0x400E995")]
	[FieldOffset(Offset = "0x18")]
	public int maxIndex;

	[Token(Token = "0x400E996")]
	[FieldOffset(Offset = "0x1C")]
	public bool hideInactive;

	[Token(Token = "0x400E997")]
	[FieldOffset(Offset = "0x20")]
	public OnInitializeItem onInitializeItem;

	[Token(Token = "0x400E998")]
	[FieldOffset(Offset = "0x24")]
	protected Transform mTrans;

	[Token(Token = "0x400E999")]
	[FieldOffset(Offset = "0x28")]
	protected UIPanel mPanel;

	[Token(Token = "0x400E99A")]
	[FieldOffset(Offset = "0x2C")]
	protected UIScrollView mScroll;

	[Token(Token = "0x400E99B")]
	[FieldOffset(Offset = "0x30")]
	protected bool mHorizontal;

	[Token(Token = "0x400E99C")]
	[FieldOffset(Offset = "0x31")]
	protected bool mFirstTime;

	[Token(Token = "0x400E99D")]
	[FieldOffset(Offset = "0x34")]
	protected List<Transform> mChildren;

	[Token(Token = "0x400E99E")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Transform> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x400E99F")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<Transform> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x400E9A0")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<Transform> _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x600DDA2")]
	[Address(RVA = "0x146ADB4", Offset = "0x146ADB4", VA = "0x146ADB4")]
	public UICustomizedWrapContent()
	{
	}

	[Token(Token = "0x600DDA3")]
	[Address(RVA = "0x146AE54", Offset = "0x146AE54", VA = "0x146AE54", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600DDA4")]
	[Address(RVA = "0x146AF8C", Offset = "0x146AF8C", VA = "0x146AF8C", Slot = "5")]
	protected virtual void OnMove(UIPanel panel)
	{
	}

	[Token(Token = "0x600DDA5")]
	[Address(RVA = "0x146AF9C", Offset = "0x146AF9C", VA = "0x146AF9C", Slot = "6")]
	public virtual void SortBasedOnScrollMovement()
	{
	}

	[Token(Token = "0x600DDA6")]
	[Address(RVA = "0x146B3F0", Offset = "0x146B3F0", VA = "0x146B3F0", Slot = "7")]
	public virtual void SortAlphabetically()
	{
	}

	[Token(Token = "0x600DDA7")]
	[Address(RVA = "0x146B268", Offset = "0x146B268", VA = "0x146B268")]
	protected bool CacheScrollView()
	{
		return default(bool);
	}

	[Token(Token = "0x600DDA8")]
	[Address(RVA = "0x146B61C", Offset = "0x146B61C", VA = "0x146B61C", Slot = "8")]
	protected virtual void ResetChildPositions()
	{
	}

	[Token(Token = "0x600DDA9")]
	[Address(RVA = "0x146B7BC", Offset = "0x146B7BC", VA = "0x146B7BC")]
	public void RefreshChildren()
	{
	}

	[Token(Token = "0x600DDAA")]
	[Address(RVA = "0x146B89C", Offset = "0x146B89C", VA = "0x146B89C", Slot = "9")]
	public virtual void WrapContent()
	{
	}

	[Token(Token = "0x600DDAB")]
	[Address(RVA = "0x146C20C", Offset = "0x146C20C", VA = "0x146C20C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600DDAC")]
	[Address(RVA = "0x146C22C", Offset = "0x146C22C", VA = "0x146C22C", Slot = "10")]
	protected virtual void UpdateItem(Transform item, int index)
	{
	}
}
