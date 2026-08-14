using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004178")]
public class UIWrapContentExtend : UIWrapContentBase
{
	[Token(Token = "0x2004179")]
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	[Token(Token = "0x401B748")]
	[FieldOffset(Offset = "0xC")]
	public int m_columns;

	[Token(Token = "0x401B749")]
	[FieldOffset(Offset = "0x10")]
	public int itemWidth;

	[Token(Token = "0x401B74A")]
	[FieldOffset(Offset = "0x14")]
	public int itemHeight;

	[Token(Token = "0x401B74B")]
	[FieldOffset(Offset = "0x18")]
	public bool cullContent;

	[Token(Token = "0x401B74C")]
	[FieldOffset(Offset = "0x1C")]
	public int minIndex;

	[Token(Token = "0x401B74D")]
	[FieldOffset(Offset = "0x20")]
	public int maxIndex;

	[Token(Token = "0x401B74E")]
	[FieldOffset(Offset = "0x24")]
	public OnInitializeItem onInitializeItem;

	[Token(Token = "0x401B74F")]
	[FieldOffset(Offset = "0x28")]
	private Transform mTrans;

	[Token(Token = "0x401B750")]
	[FieldOffset(Offset = "0x2C")]
	public UIPanel mPanel;

	[Token(Token = "0x401B751")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView mScroll;

	[Token(Token = "0x401B752")]
	[FieldOffset(Offset = "0x34")]
	private bool mHorizontal;

	[Token(Token = "0x401B753")]
	[FieldOffset(Offset = "0x35")]
	private bool mFirstTime;

	[Token(Token = "0x401B754")]
	[FieldOffset(Offset = "0x38")]
	private List<Transform> mChildren;

	[Token(Token = "0x401B755")]
	[FieldOffset(Offset = "0x3C")]
	private bool _003CForceResetScroll_003Ek__BackingField;

	[Token(Token = "0x401B756")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Transform> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x401B757")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<Transform> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x401B758")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<Transform> _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x17001D7A")]
	public bool ForceResetScroll
	{
		[Token(Token = "0x601ABF9")]
		[Address(RVA = "0x2BC273C", Offset = "0x2BC273C", VA = "0x2BC273C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601ABFA")]
		[Address(RVA = "0x2BC2744", Offset = "0x2BC2744", VA = "0x2BC2744")]
		set
		{
		}
	}

	[Token(Token = "0x17001D7B")]
	public override Movement ScrollViewMovement
	{
		[Token(Token = "0x601ABFB")]
		[Address(RVA = "0x2BC274C", Offset = "0x2BC274C", VA = "0x2BC274C", Slot = "4")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Movement);
		}
	}

	[Token(Token = "0x17001D7C")]
	public override float CellHeight
	{
		[Token(Token = "0x601ABFC")]
		[Address(RVA = "0x2BC2758", Offset = "0x2BC2758", VA = "0x2BC2758", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001D7D")]
	public override float CellWidth
	{
		[Token(Token = "0x601ABFD")]
		[Address(RVA = "0x2BC2768", Offset = "0x2BC2768", VA = "0x2BC2768", Slot = "6")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x601ABF7")]
	[Address(RVA = "0x2BC2420", Offset = "0x2BC2420", VA = "0x2BC2420")]
	public UIWrapContentExtend()
	{
	}

	[Token(Token = "0x601ABF8")]
	[Address(RVA = "0x2BC24C8", Offset = "0x2BC24C8", VA = "0x2BC24C8")]
	public void InitEasyList(UIScrollView scrollView, int columns)
	{
	}

	[Token(Token = "0x601ABFE")]
	[Address(RVA = "0x2BC2778", Offset = "0x2BC2778", VA = "0x2BC2778", Slot = "7")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x601ABFF")]
	[Address(RVA = "0x2BC2880", Offset = "0x2BC2880", VA = "0x2BC2880")]
	public void ForceSetMoveDelegate()
	{
	}

	[Token(Token = "0x601AC00")]
	[Address(RVA = "0x2BC2988", Offset = "0x2BC2988", VA = "0x2BC2988", Slot = "8")]
	public virtual void ResetChilds(bool resetScroll = true, bool resortChildren = true)
	{
	}

	[Token(Token = "0x601AC01")]
	[Address(RVA = "0x2BC2C98", Offset = "0x2BC2C98", VA = "0x2BC2C98", Slot = "9")]
	public virtual void Refresh()
	{
	}

	[Token(Token = "0x601AC02")]
	[Address(RVA = "0x2BC2DC8", Offset = "0x2BC2DC8", VA = "0x2BC2DC8", Slot = "10")]
	protected virtual void OnMove(UIPanel panel)
	{
	}

	[Token(Token = "0x601AC03")]
	[Address(RVA = "0x2BC29B0", Offset = "0x2BC29B0", VA = "0x2BC29B0")]
	public void SortBasedOnScrollMovement(bool resetScroll = true, bool resortChildren = true)
	{
	}

	[Token(Token = "0x601AC04")]
	[Address(RVA = "0x2BC4000", Offset = "0x2BC4000", VA = "0x2BC4000")]
	public void SortAlphabetically()
	{
	}

	[Token(Token = "0x601AC05")]
	[Address(RVA = "0x2BC25A4", Offset = "0x2BC25A4", VA = "0x2BC25A4")]
	protected bool CacheScrollView()
	{
		return default(bool);
	}

	[Token(Token = "0x601AC06")]
	[Address(RVA = "0x2BC3E28", Offset = "0x2BC3E28", VA = "0x2BC3E28")]
	private void ResetChildPositions(bool resetScroll = true)
	{
	}

	[Token(Token = "0x601AC07")]
	[Address(RVA = "0x2BC2DCC", Offset = "0x2BC2DCC", VA = "0x2BC2DCC")]
	public void WrapContent()
	{
	}

	[Token(Token = "0x601AC08")]
	[Address(RVA = "0x2BC4AA8", Offset = "0x2BC4AA8", VA = "0x2BC4AA8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x601AC09")]
	[Address(RVA = "0x2BC4AC8", Offset = "0x2BC4AC8", VA = "0x2BC4AC8", Slot = "11")]
	protected virtual void UpdateItem(Transform item, int index)
	{
	}

	[Token(Token = "0x601AC0A")]
	[Address(RVA = "0x2BC4718", Offset = "0x2BC4718", VA = "0x2BC4718")]
	protected int GetRealIndex(Vector2 itemLocalPosition, bool isNature = false)
	{
		return default(int);
	}

	[Token(Token = "0x601AC0B")]
	[Address(RVA = "0x2BC4898", Offset = "0x2BC4898", VA = "0x2BC4898")]
	protected int GetFullFillChildrenSize()
	{
		return default(int);
	}

	[Token(Token = "0x601AC0C")]
	[Address(RVA = "0x2BC4500", Offset = "0x2BC4500", VA = "0x2BC4500")]
	public Vector3 GetPositionAtIndex(int index)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601AC0D")]
	[Address(RVA = "0x2BC4218", Offset = "0x2BC4218", VA = "0x2BC4218")]
	public int GetCurrentRealIndex(out float offset)
	{
		return default(int);
	}
}
