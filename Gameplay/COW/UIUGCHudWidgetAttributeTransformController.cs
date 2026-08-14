using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200241E")]
public class UIUGCHudWidgetAttributeTransformController : UIUGCHudWidgetAttributeController<UIUGCHudWidgetAttributeTransformController.TransformData>
{
	[Token(Token = "0x200241F")]
	public struct TransformData : _Attribute
	{
		[Token(Token = "0x400E0DB")]
		[FieldOffset(Offset = "0x0")]
		public int X;

		[Token(Token = "0x400E0DC")]
		[FieldOffset(Offset = "0x4")]
		public int Y;

		[Token(Token = "0x400E0DD")]
		[FieldOffset(Offset = "0x8")]
		public int Width;

		[Token(Token = "0x400E0DE")]
		[FieldOffset(Offset = "0xC")]
		public int Height;

		[Token(Token = "0x400E0DF")]
		[FieldOffset(Offset = "0x10")]
		public int Angle;

		[Token(Token = "0x600CC46")]
		[Address(RVA = "0x93DBC4", Offset = "0x93DBC4", VA = "0x93DBC4")]
		public void SetX(int x)
		{
		}

		[Token(Token = "0x600CC47")]
		[Address(RVA = "0x93DBCC", Offset = "0x93DBCC", VA = "0x93DBCC")]
		public void SetY(int y)
		{
		}

		[Token(Token = "0x600CC48")]
		[Address(RVA = "0x93DBD4", Offset = "0x93DBD4", VA = "0x93DBD4")]
		public void SetWidth(int width)
		{
		}

		[Token(Token = "0x600CC49")]
		[Address(RVA = "0x93DBDC", Offset = "0x93DBDC", VA = "0x93DBDC")]
		public void SetHeight(int height)
		{
		}

		[Token(Token = "0x600CC4A")]
		[Address(RVA = "0x93DBE4", Offset = "0x93DBE4", VA = "0x93DBE4")]
		public void SetAngle(int angle)
		{
		}

		[Token(Token = "0x600CC4B")]
		[Address(RVA = "0x2FFD494", Offset = "0x2FFD494", VA = "0x2FFD494")]
		public static TransformData Create(Vector2 localPosition, int width, int height, float angle)
		{
			return default(TransformData);
		}

		[Token(Token = "0x600CC4C")]
		[Address(RVA = "0x93DBEC", Offset = "0x93DBEC", VA = "0x93DBEC", Slot = "4")]
		public bool Equals(TransformData other)
		{
			return default(bool);
		}

		[Token(Token = "0x600CC4D")]
		[Address(RVA = "0x93DC14", Offset = "0x93DC14", VA = "0x93DC14", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600CC4E")]
		[Address(RVA = "0x93DC1C", Offset = "0x93DC1C", VA = "0x93DC1C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600CC4F")]
		[Address(RVA = "0x93DC24", Offset = "0x93DC24", VA = "0x93DC24")]
		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return default(bool);
		}

		[Token(Token = "0x600CC50")]
		[Address(RVA = "0x93DC2C", Offset = "0x93DC2C", VA = "0x93DC2C")]
		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x400E0D4")]
	[FieldOffset(Offset = "0x44")]
	private UIUGCHudWidgetAttributeTransformView m_View;

	[Token(Token = "0x400E0D5")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCHudWidgetAttributeTransformItemController m_ItemX;

	[Token(Token = "0x400E0D6")]
	[FieldOffset(Offset = "0x4C")]
	private UIUGCHudWidgetAttributeTransformItemController m_ItemY;

	[Token(Token = "0x400E0D7")]
	[FieldOffset(Offset = "0x50")]
	private UIUGCHudWidgetAttributeTransformItemController m_ItemWidth;

	[Token(Token = "0x400E0D8")]
	[FieldOffset(Offset = "0x54")]
	private UIUGCHudWidgetAttributeTransformItemController m_ItemHeight;

	[Token(Token = "0x400E0D9")]
	[FieldOffset(Offset = "0x58")]
	private UIUGCHudWidgetAttributeTransformItemController m_ItemAngle;

	[Token(Token = "0x400E0DA")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsExtend;

	[Token(Token = "0x17001103")]
	public override TransformData AttributeData
	{
		[Token(Token = "0x600CC39")]
		[Address(RVA = "0x2FFC43C", Offset = "0x2FFC43C", VA = "0x2FFC43C", Slot = "36")]
		get
		{
			return default(TransformData);
		}
		[Token(Token = "0x600CC3A")]
		[Address(RVA = "0x2FFC4B0", Offset = "0x2FFC4B0", VA = "0x2FFC4B0", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x600CC34")]
	[Address(RVA = "0x2FFB5AC", Offset = "0x2FFB5AC", VA = "0x2FFB5AC")]
	public UIUGCHudWidgetAttributeTransformController()
	{
	}

	[Token(Token = "0x600CC35")]
	[Address(RVA = "0x2FFB610", Offset = "0x2FFB610", VA = "0x2FFB610")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CC36")]
	[Address(RVA = "0x2FFB6B4", Offset = "0x2FFB6B4", VA = "0x2FFB6B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CC37")]
	[Address(RVA = "0x2FFBC24", Offset = "0x2FFBC24", VA = "0x2FFBC24", Slot = "31")]
	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return default(UIUGCHudWidgetAttributeEnum);
	}

	[Token(Token = "0x600CC38")]
	[Address(RVA = "0x2FFBC7C", Offset = "0x2FFBC7C", VA = "0x2FFBC7C", Slot = "38")]
	public override void InitAttribute(TransformData data)
	{
	}

	[Token(Token = "0x600CC3B")]
	[Address(RVA = "0x2FFC670", Offset = "0x2FFC670", VA = "0x2FFC670")]
	public void InitAttributePosition(int x, int y)
	{
	}

	[Token(Token = "0x600CC3C")]
	[Address(RVA = "0x2FFC8B4", Offset = "0x2FFC8B4", VA = "0x2FFC8B4")]
	public void InitAttributeSize(int width, int height)
	{
	}

	[Token(Token = "0x600CC3D")]
	[Address(RVA = "0x2FFCAF8", Offset = "0x2FFCAF8", VA = "0x2FFCAF8")]
	public void InitAttributeAngle(int angle)
	{
	}

	[Token(Token = "0x600CC3E")]
	[Address(RVA = "0x2FFB818", Offset = "0x2FFB818", VA = "0x2FFB818")]
	private void InitTransformItems()
	{
	}

	[Token(Token = "0x600CC3F")]
	[Address(RVA = "0x2FFCC4C", Offset = "0x2FFCC4C", VA = "0x2FFCC4C")]
	private void OnXChanged()
	{
	}

	[Token(Token = "0x600CC40")]
	[Address(RVA = "0x2FFCDF0", Offset = "0x2FFCDF0", VA = "0x2FFCDF0")]
	private void OnYChanged()
	{
	}

	[Token(Token = "0x600CC41")]
	[Address(RVA = "0x2FFCF3C", Offset = "0x2FFCF3C", VA = "0x2FFCF3C")]
	private void OnWidthChanged()
	{
	}

	[Token(Token = "0x600CC42")]
	[Address(RVA = "0x2FFD088", Offset = "0x2FFD088", VA = "0x2FFD088")]
	private void OnHeightChanged()
	{
	}

	[Token(Token = "0x600CC43")]
	[Address(RVA = "0x2FFD1D4", Offset = "0x2FFD1D4", VA = "0x2FFD1D4")]
	private void OnAngleChanged()
	{
	}

	[Token(Token = "0x600CC44")]
	[Address(RVA = "0x2FFD320", Offset = "0x2FFD320", VA = "0x2FFD320")]
	private void OnClickBtn()
	{
	}

	[Token(Token = "0x600CC45")]
	[Address(RVA = "0x2FFD48C", Offset = "0x2FFD48C", VA = "0x2FFD48C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
