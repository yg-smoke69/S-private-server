using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000BDD")]
public class UIHudBlockEditColorSetterWndController : UIPopupWindowController
{
	[Token(Token = "0x2000BDE")]
	private sealed class _003CSetPosition_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40062E1")]
		[FieldOffset(Offset = "0x8")]
		internal Transform _003CcontentTr_003E__0;

		[Token(Token = "0x40062E2")]
		[FieldOffset(Offset = "0xC")]
		internal Vector3 Pos;

		[Token(Token = "0x40062E3")]
		[FieldOffset(Offset = "0x18")]
		internal Vector3 _003Ccenter_003E__0;

		[Token(Token = "0x40062E4")]
		[FieldOffset(Offset = "0x24")]
		internal Bounds _003Cbounds_003E__0;

		[Token(Token = "0x40062E5")]
		[FieldOffset(Offset = "0x3C")]
		internal Vector3 _003CcontentLocalPos_003E__0;

		[Token(Token = "0x40062E6")]
		[FieldOffset(Offset = "0x48")]
		internal UIHudBlockEditColorSetterWndController _0024this;

		[Token(Token = "0x40062E7")]
		[FieldOffset(Offset = "0x4C")]
		internal object _0024current;

		[Token(Token = "0x40062E8")]
		[FieldOffset(Offset = "0x50")]
		internal bool _0024disposing;

		[Token(Token = "0x40062E9")]
		[FieldOffset(Offset = "0x54")]
		internal int _0024PC;

		[Token(Token = "0x17000774")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005A00")]
			[Address(RVA = "0x1E032C8", Offset = "0x1E032C8", VA = "0x1E032C8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000775")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005A01")]
			[Address(RVA = "0x1E032D0", Offset = "0x1E032D0", VA = "0x1E032D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60059FE")]
		[Address(RVA = "0x1E01F54", Offset = "0x1E01F54", VA = "0x1E01F54")]
		public _003CSetPosition_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60059FF")]
		[Address(RVA = "0x1E02EC4", Offset = "0x1E02EC4", VA = "0x1E02EC4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005A02")]
		[Address(RVA = "0x1E032D8", Offset = "0x1E032D8", VA = "0x1E032D8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005A03")]
		[Address(RVA = "0x1E032EC", Offset = "0x1E032EC", VA = "0x1E032EC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000BDF")]
	private sealed class _003CLoadLatestColor_003Ec__AnonStorey1
	{
		[Token(Token = "0x40062EA")]
		[FieldOffset(Offset = "0x8")]
		internal Color c;

		[Token(Token = "0x40062EB")]
		[FieldOffset(Offset = "0x18")]
		internal UIHudBlockEditColorSetterWndController _0024this;

		[Token(Token = "0x6005A04")]
		[Address(RVA = "0x1E02DC4", Offset = "0x1E02DC4", VA = "0x1E02DC4")]
		public _003CLoadLatestColor_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6005A05")]
		[Address(RVA = "0x1E02E74", Offset = "0x1E02E74", VA = "0x1E02E74")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x40062D1")]
	[FieldOffset(Offset = "0x48")]
	private UIHudBlockEditColorSetterWndView m_View;

	[Token(Token = "0x40062D2")]
	[FieldOffset(Offset = "0x4C")]
	private float mHue;

	[Token(Token = "0x40062D3")]
	[FieldOffset(Offset = "0x50")]
	private float mSaturation;

	[Token(Token = "0x40062D4")]
	[FieldOffset(Offset = "0x54")]
	private float mBrightness;

	[Token(Token = "0x40062D5")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 SVTextureSize;

	[Token(Token = "0x40062D6")]
	[FieldOffset(Offset = "0x60")]
	public ColorChangedEvent onValueChanged;

	[Token(Token = "0x40062D7")]
	[FieldOffset(Offset = "0x64")]
	public HSVChangedEvent onHSVChanged;

	[Token(Token = "0x40062D8")]
	[FieldOffset(Offset = "0x68")]
	public Action onClosed;

	[Token(Token = "0x40062D9")]
	[FieldOffset(Offset = "0x6C")]
	private List<Color> m_LatestColor;

	[Token(Token = "0x40062DA")]
	[FieldOffset(Offset = "0x70")]
	private int m_LatestColorIndex;

	[Token(Token = "0x40062DB")]
	private const string COLORPRESET = "UGC_Color";

	[Token(Token = "0x40062DC")]
	private const string LATESTCOLORINDEX = "Latest_UGC_Color_Index";

	[Token(Token = "0x40062DD")]
	private const int MAXPRESETCOLOTCNT = 10;

	[Token(Token = "0x40062DE")]
	[FieldOffset(Offset = "0x74")]
	private Color mColor;

	[Token(Token = "0x40062DF")]
	private const float m_HeightSpace = 40f;

	[Token(Token = "0x40062E0")]
	[FieldOffset(Offset = "0x84")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x1700076C")]
	public Color CurrentColor
	{
		[Token(Token = "0x60059DB")]
		[Address(RVA = "0x1E00234", Offset = "0x1E00234", VA = "0x1E00234")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Color);
		}
		[Token(Token = "0x60059DC")]
		[Address(RVA = "0x1E002A0", Offset = "0x1E002A0", VA = "0x1E002A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700076D")]
	public float H
	{
		[Token(Token = "0x60059E2")]
		[Address(RVA = "0x1E01F5C", Offset = "0x1E01F5C", VA = "0x1E01F5C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60059E3")]
		[Address(RVA = "0x1E01FB4", Offset = "0x1E01FB4", VA = "0x1E01FB4")]
		set
		{
		}
	}

	[Token(Token = "0x1700076E")]
	public float S
	{
		[Token(Token = "0x60059E4")]
		[Address(RVA = "0x1E0214C", Offset = "0x1E0214C", VA = "0x1E0214C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60059E5")]
		[Address(RVA = "0x1E021A4", Offset = "0x1E021A4", VA = "0x1E021A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700076F")]
	public float V
	{
		[Token(Token = "0x60059E6")]
		[Address(RVA = "0x1E0222C", Offset = "0x1E0222C", VA = "0x1E0222C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60059E7")]
		[Address(RVA = "0x1E02284", Offset = "0x1E02284", VA = "0x1E02284")]
		set
		{
		}
	}

	[Token(Token = "0x17000770")]
	public float R
	{
		[Token(Token = "0x60059E8")]
		[Address(RVA = "0x1E0230C", Offset = "0x1E0230C", VA = "0x1E0230C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60059E9")]
		[Address(RVA = "0x1E02364", Offset = "0x1E02364", VA = "0x1E02364")]
		set
		{
		}
	}

	[Token(Token = "0x17000771")]
	public float G
	{
		[Token(Token = "0x60059EA")]
		[Address(RVA = "0x1E023EC", Offset = "0x1E023EC", VA = "0x1E023EC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60059EB")]
		[Address(RVA = "0x1E02444", Offset = "0x1E02444", VA = "0x1E02444")]
		set
		{
		}
	}

	[Token(Token = "0x17000772")]
	public float B
	{
		[Token(Token = "0x60059EC")]
		[Address(RVA = "0x1E024CC", Offset = "0x1E024CC", VA = "0x1E024CC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60059ED")]
		[Address(RVA = "0x1E02524", Offset = "0x1E02524", VA = "0x1E02524")]
		set
		{
		}
	}

	[Token(Token = "0x17000773")]
	private float A
	{
		[Token(Token = "0x60059EE")]
		[Address(RVA = "0x1E025AC", Offset = "0x1E025AC", VA = "0x1E025AC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60059EF")]
		[Address(RVA = "0x1E02604", Offset = "0x1E02604", VA = "0x1E02604")]
		set
		{
		}
	}

	[Token(Token = "0x60059DA")]
	[Address(RVA = "0x1E0012C", Offset = "0x1E0012C", VA = "0x1E0012C")]
	public UIHudBlockEditColorSetterWndController()
	{
	}

	[Token(Token = "0x60059DD")]
	[Address(RVA = "0x1E007B4", Offset = "0x1E007B4", VA = "0x1E007B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60059DE")]
	[Address(RVA = "0x1E00858", Offset = "0x1E00858", VA = "0x1E00858", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60059DF")]
	[Address(RVA = "0x1E01AF8", Offset = "0x1E01AF8", VA = "0x1E01AF8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60059E0")]
	[Address(RVA = "0x1E01DA8", Offset = "0x1E01DA8", VA = "0x1E01DA8")]
	public void SetPos(Vector3 pos)
	{
	}

	[Token(Token = "0x60059E1")]
	[Address(RVA = "0x1E01E48", Offset = "0x1E01E48", VA = "0x1E01E48")]
	private IEnumerator SetPosition(Vector3 Pos)
	{
		return null;
	}

	[Token(Token = "0x60059F0")]
	[Address(RVA = "0x1E02684", Offset = "0x1E02684", VA = "0x1E02684")]
	public void SetCurrentColor(Color color)
	{
	}

	[Token(Token = "0x60059F1")]
	[Address(RVA = "0x1E0271C", Offset = "0x1E0271C", VA = "0x1E0271C")]
	private void OnSVTextureDrag(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x60059F2")]
	[Address(RVA = "0x1E02A24", Offset = "0x1E02A24", VA = "0x1E02A24")]
	private void OnSVTexturePress(GameObject go, bool state)
	{
	}

	[Token(Token = "0x60059F3")]
	[Address(RVA = "0x1E027A0", Offset = "0x1E027A0", VA = "0x1E027A0")]
	private void OnSVTextureDragOrPress()
	{
	}

	[Token(Token = "0x60059F4")]
	[Address(RVA = "0x1E00370", Offset = "0x1E00370", VA = "0x1E00370")]
	private void RGBChanged()
	{
	}

	[Token(Token = "0x60059F5")]
	[Address(RVA = "0x1E0203C", Offset = "0x1E0203C", VA = "0x1E0203C")]
	private void HSVChanged()
	{
	}

	[Token(Token = "0x60059F6")]
	[Address(RVA = "0x1E00678", Offset = "0x1E00678", VA = "0x1E00678")]
	private void SendChangedEvent()
	{
	}

	[Token(Token = "0x60059F7")]
	[Address(RVA = "0x1E02AB0", Offset = "0x1E02AB0", VA = "0x1E02AB0")]
	private void OnHSVSliderBar()
	{
	}

	[Token(Token = "0x60059F8")]
	[Address(RVA = "0x1E01530", Offset = "0x1E01530", VA = "0x1E01530")]
	private void GenerateHueBar()
	{
	}

	[Token(Token = "0x60059F9")]
	[Address(RVA = "0x1E017AC", Offset = "0x1E017AC", VA = "0x1E017AC")]
	private void GenerateSVTexture()
	{
	}

	[Token(Token = "0x60059FA")]
	[Address(RVA = "0x1E00DC0", Offset = "0x1E00DC0", VA = "0x1E00DC0")]
	private void LoadLatestColor()
	{
	}

	[Token(Token = "0x60059FB")]
	[Address(RVA = "0x1E02DCC", Offset = "0x1E02DCC", VA = "0x1E02DCC")]
	private void OnColorPresetClick(Color c)
	{
	}

	[Token(Token = "0x60059FC")]
	[Address(RVA = "0x1E02E64", Offset = "0x1E02E64", VA = "0x1E02E64")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60059FD")]
	[Address(RVA = "0x1E02E6C", Offset = "0x1E02E6C", VA = "0x1E02E6C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
