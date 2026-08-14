using System.Runtime.InteropServices;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002486")]
public abstract class UIHUDUGC_WidgetBaseController : _Attribute
{
	[Token(Token = "0x400E287")]
	[FieldOffset(Offset = "0x8")]
	protected UGCHudWidget m_Widget;

	[Token(Token = "0x400E288")]
	[FieldOffset(Offset = "0xC")]
	protected string m_EntityID;

	[Token(Token = "0x400E289")]
	[FieldOffset(Offset = "0x10")]
	private string m_HudEntityId;

	[Token(Token = "0x400E28A")]
	[FieldOffset(Offset = "0x14")]
	private int m_WidgetId;

	[Token(Token = "0x400E28B")]
	[FieldOffset(Offset = "0x18")]
	private UIHUDUGC_CustomHudController m_HudController;

	[Token(Token = "0x17001119")]
	public string HostHudEntityID
	{
		[Token(Token = "0x600D092")]
		[Address(RVA = "0x293079C", Offset = "0x293079C", VA = "0x293079C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700111A")]
	public int WidgetID
	{
		[Token(Token = "0x600D093")]
		[Address(RVA = "0x29307F4", Offset = "0x29307F4", VA = "0x29307F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700111B")]
	protected UIHUDUGC_CustomHudController HudController
	{
		[Token(Token = "0x600D098")]
		[Address(RVA = "0x29308F4", Offset = "0x29308F4", VA = "0x29308F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600D08D")]
	[Address(RVA = "0x2930400", Offset = "0x2930400", VA = "0x2930400")]
	protected UIHUDUGC_WidgetBaseController()
	{
	}

	[Token(Token = "0x600D08E")]
	[Address(RVA = "0x2930408", Offset = "0x2930408", VA = "0x2930408")]
	public void BindWidget(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600D08F")]
	[Address(RVA = "0x2930518", Offset = "0x2930518", VA = "0x2930518", Slot = "4")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600D090")]
	[Address(RVA = "0x2930590", Offset = "0x2930590", VA = "0x2930590", Slot = "5")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600D091")]
	[Address(RVA = "0x2930604", Offset = "0x2930604", VA = "0x2930604")]
	public static UIHUDUGC_WidgetBaseController Rebuild(FONLAPPBCOO entityType, string entityID)
	{
		return null;
	}

	[Token(Token = "0x600D094")]
	protected abstract void InitEntityData();

	[Token(Token = "0x600D095")]
	protected abstract void OnDestroy();

	[Token(Token = "0x600D096")]
	[Address(RVA = "0x293084C", Offset = "0x293084C", VA = "0x293084C", Slot = "8")]
	protected virtual void InitWidget()
	{
	}

	[Token(Token = "0x600D097")]
	[Address(RVA = "0x29308A0", Offset = "0x29308A0", VA = "0x29308A0", Slot = "9")]
	protected virtual void RefreshWidgetInfo()
	{
	}

	[Token(Token = "0x600D099")]
	[Address(RVA = "0x2930AE0", Offset = "0x2930AE0", VA = "0x2930AE0")]
	protected void OnActiveSelfChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D09A")]
	[Address(RVA = "0x2930C24", Offset = "0x2930C24", VA = "0x2930C24")]
	protected void OnLocalPositionChanged(Vector3 old, Vector3 cur)
	{
	}

	[Token(Token = "0x600D09B")]
	[Address(RVA = "0x2930DC8", Offset = "0x2930DC8", VA = "0x2930DC8")]
	protected void OnWidthChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D09C")]
	[Address(RVA = "0x2930EF0", Offset = "0x2930EF0", VA = "0x2930EF0")]
	protected void OnHeightChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D09D")]
	[Address(RVA = "0x2931018", Offset = "0x2931018", VA = "0x2931018")]
	protected void OnAngleChanged(float old, float cur)
	{
	}

	[Token(Token = "0x600D09E")]
	[Address(RVA = "0x2931154", Offset = "0x2931154", VA = "0x2931154")]
	protected void OnColorChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D09F")]
	[Address(RVA = "0x29312C0", Offset = "0x29312C0", VA = "0x29312C0")]
	protected void OnHostHudEntityIDChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600D0A0")]
	[Address(RVA = "0x293133C", Offset = "0x293133C", VA = "0x293133C")]
	protected void OnFileIDChanged(int old, int cur)
	{
	}
}
