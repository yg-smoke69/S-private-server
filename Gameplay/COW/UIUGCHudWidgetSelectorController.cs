using GCommon;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200243E")]
public class UIUGCHudWidgetSelectorController : UIBaseController
{
	[Token(Token = "0x400E162")]
	[FieldOffset(Offset = "0x28")]
	private UIUGCHudWidgetSelectorView m_View;

	[Token(Token = "0x400E163")]
	[FieldOffset(Offset = "0x2C")]
	private UGCHudWidget m_Widget;

	[Token(Token = "0x400E164")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_FrameTrans;

	[Token(Token = "0x400E165")]
	[FieldOffset(Offset = "0x34")]
	private UIModelUGCHudEdit m_Model;

	[Token(Token = "0x400E166")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsPressWidget;

	[Token(Token = "0x400E167")]
	[FieldOffset(Offset = "0x39")]
	private bool m_IsDrag;

	[Token(Token = "0x400E168")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 m_LastLocalPosition;

	[Token(Token = "0x400E169")]
	private const int MIN_WIDTH = 6;

	[Token(Token = "0x400E16A")]
	private const int MIN_HEIGHT = 6;

	[Token(Token = "0x17001111")]
	public int Width
	{
		[Token(Token = "0x600CD80")]
		[Address(RVA = "0x2776B6C", Offset = "0x2776B6C", VA = "0x2776B6C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001112")]
	public int Height
	{
		[Token(Token = "0x600CD81")]
		[Address(RVA = "0x2776BF8", Offset = "0x2776BF8", VA = "0x2776BF8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001113")]
	public Transform FrameTrans
	{
		[Token(Token = "0x600CD82")]
		[Address(RVA = "0x2776C84", Offset = "0x2776C84", VA = "0x2776C84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001114")]
	public UIWidget FrameWidget
	{
		[Token(Token = "0x600CD83")]
		[Address(RVA = "0x2776CDC", Offset = "0x2776CDC", VA = "0x2776CDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001115")]
	public UGCHudWidget Widget
	{
		[Token(Token = "0x600CD84")]
		[Address(RVA = "0x2776D4C", Offset = "0x2776D4C", VA = "0x2776D4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600CD7D")]
	[Address(RVA = "0x2775EB8", Offset = "0x2775EB8", VA = "0x2775EB8")]
	public UIUGCHudWidgetSelectorController()
	{
	}

	[Token(Token = "0x600CD7E")]
	[Address(RVA = "0x2775F3C", Offset = "0x2775F3C", VA = "0x2775F3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CD7F")]
	[Address(RVA = "0x2775FE0", Offset = "0x2775FE0", VA = "0x2775FE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CD85")]
	[Address(RVA = "0x2776DA4", Offset = "0x2776DA4", VA = "0x2776DA4")]
	public void BindWidget(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CD86")]
	[Address(RVA = "0x2777840", Offset = "0x2777840", VA = "0x2777840")]
	public void SetPosition(Vector3 positon)
	{
	}

	[Token(Token = "0x600CD87")]
	[Address(RVA = "0x2777968", Offset = "0x2777968", VA = "0x2777968")]
	public void SetRotation(Quaternion rotation)
	{
	}

	[Token(Token = "0x600CD88")]
	[Address(RVA = "0x2777AEC", Offset = "0x2777AEC", VA = "0x2777AEC")]
	public void ResizeWidget(Pivot pivot, float x, float y)
	{
	}

	[Token(Token = "0x600CD89")]
	[Address(RVA = "0x2777F94", Offset = "0x2777F94", VA = "0x2777F94")]
	public void RotateWidget(float deltaAngle)
	{
	}

	[Token(Token = "0x600CD8A")]
	[Address(RVA = "0x27780C0", Offset = "0x27780C0", VA = "0x27780C0")]
	private void OnBindWidgetHorizontalAlignmentChanged(UGCHudWidget.HorizontalAlignmentEnum value)
	{
	}

	[Token(Token = "0x600CD8B")]
	[Address(RVA = "0x27782D8", Offset = "0x27782D8", VA = "0x27782D8")]
	private void OnBindWidgetVerticalAlignmentChanged(UGCHudWidget.VerticalAlignmentEnum value)
	{
	}

	[Token(Token = "0x600CD8C")]
	[Address(RVA = "0x27784F0", Offset = "0x27784F0", VA = "0x27784F0")]
	private void OnBindWidgetPositionChanged()
	{
	}

	[Token(Token = "0x600CD8D")]
	[Address(RVA = "0x2778620", Offset = "0x2778620", VA = "0x2778620")]
	private void OnBindWidgetRotationChanged()
	{
	}

	[Token(Token = "0x600CD8E")]
	[Address(RVA = "0x2778758", Offset = "0x2778758", VA = "0x2778758")]
	private void OnBindWidgetSizeChanged()
	{
	}

	[Token(Token = "0x600CD8F")]
	[Address(RVA = "0x27789AC", Offset = "0x27789AC", VA = "0x27789AC")]
	private void OnDragStart(GameObject go)
	{
	}

	[Token(Token = "0x600CD90")]
	[Address(RVA = "0x2778E28", Offset = "0x2778E28", VA = "0x2778E28")]
	private void OnDrag(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x600CD91")]
	[Address(RVA = "0x27791C8", Offset = "0x27791C8", VA = "0x27791C8")]
	private void OnDragEnd(GameObject go)
	{
	}

	[Token(Token = "0x600CD92")]
	[Address(RVA = "0x27792F8", Offset = "0x27792F8", VA = "0x27792F8")]
	private void OnWidgetPress(GameObject go, bool pressed)
	{
	}

	[Token(Token = "0x600CD93")]
	[Address(RVA = "0x27794AC", Offset = "0x27794AC", VA = "0x27794AC")]
	private void OnWidgetDrag(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x600CD94")]
	[Address(RVA = "0x2779814", Offset = "0x2779814", VA = "0x2779814")]
	private void OnClickTopLeft(GameObject go)
	{
	}

	[Token(Token = "0x600CD95")]
	[Address(RVA = "0x2778D70", Offset = "0x2778D70", VA = "0x2778D70")]
	private void OnAdjustPointDragStart(Pivot pivotType, GameObject point)
	{
	}

	[Token(Token = "0x600CD96")]
	[Address(RVA = "0x2778EC8", Offset = "0x2778EC8", VA = "0x2778EC8")]
	private void OnAdjustPointDrag(Pivot pivotType, Vector2 delta, GameObject point)
	{
	}

	[Token(Token = "0x600CD97")]
	[Address(RVA = "0x2779244", Offset = "0x2779244", VA = "0x2779244")]
	private void OnAdjustPointDragEnd(Pivot pivotType, GameObject point)
	{
	}

	[Token(Token = "0x600CD98")]
	[Address(RVA = "0x2778A28", Offset = "0x2778A28", VA = "0x2778A28")]
	private Pivot GetPivot(GameObject go)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Pivot);
	}

	[Token(Token = "0x600CD99")]
	[Address(RVA = "0x2779CB0", Offset = "0x2779CB0", VA = "0x2779CB0")]
	private void _003COnClickTopLeft_003Em__0()
	{
	}

	[Token(Token = "0x600CD9A")]
	[Address(RVA = "0x2779CE4", Offset = "0x2779CE4", VA = "0x2779CE4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
