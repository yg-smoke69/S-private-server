using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200231C")]
public class UIHudSceneEditActionAttributeColorPanelController : UIBaseController
{
	[Token(Token = "0x200231D")]
	private sealed class _003CLoadLatestColor_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DAF2")]
		[FieldOffset(Offset = "0x8")]
		internal Color c;

		[Token(Token = "0x400DAF3")]
		[FieldOffset(Offset = "0x18")]
		internal UIHudSceneEditActionAttributeColorPanelController _0024this;

		[Token(Token = "0x600C2A3")]
		[Address(RVA = "0x1C4C3EC", Offset = "0x1C4C3EC", VA = "0x1C4C3EC")]
		public _003CLoadLatestColor_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C2A4")]
		[Address(RVA = "0x1C4C4B4", Offset = "0x1C4C4B4", VA = "0x1C4C4B4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200231E")]
	private sealed class _003CLoadLatestColor_003Ec__AnonStorey1
	{
		[Token(Token = "0x400DAF4")]
		[FieldOffset(Offset = "0x8")]
		internal Color c;

		[Token(Token = "0x400DAF5")]
		[FieldOffset(Offset = "0x18")]
		internal UIHudSceneEditActionAttributeColorPanelController _0024this;

		[Token(Token = "0x600C2A5")]
		[Address(RVA = "0x1C4C3F4", Offset = "0x1C4C3F4", VA = "0x1C4C3F4")]
		public _003CLoadLatestColor_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600C2A6")]
		[Address(RVA = "0x1C4C504", Offset = "0x1C4C504", VA = "0x1C4C504")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400DADE")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditActionAttributeColorPanelView m_View;

	[Token(Token = "0x400DADF")]
	[FieldOffset(Offset = "0x2C")]
	private float mHue;

	[Token(Token = "0x400DAE0")]
	[FieldOffset(Offset = "0x30")]
	private float mSaturation;

	[Token(Token = "0x400DAE1")]
	[FieldOffset(Offset = "0x34")]
	private float mBrightness;

	[Token(Token = "0x400DAE2")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 SVTextureSize;

	[Token(Token = "0x400DAE3")]
	[FieldOffset(Offset = "0x40")]
	public Action onClosed;

	[Token(Token = "0x400DAE4")]
	[FieldOffset(Offset = "0x44")]
	private List<Color> m_LatestColor;

	[Token(Token = "0x400DAE5")]
	private const string COLORPRESET = "ActionAttribute_Color";

	[Token(Token = "0x400DAE6")]
	private const int MAXPRESETCOLOTCNT = 9;

	[Token(Token = "0x400DAE7")]
	[FieldOffset(Offset = "0x48")]
	private UIPopMenuSmallControler m_ColorSelectedPopMenuSmallCtrl;

	[Token(Token = "0x400DAE8")]
	private const string BorderKey = "T_35_SP_WS_IMAGE04";

	[Token(Token = "0x400DAE9")]
	private const string SurfaceKey = "T_35_SP_WS_IMAGE03";

	[Token(Token = "0x400DAEA")]
	[FieldOffset(Offset = "0x4C")]
	private List<PopMenuData> m_ColorSelectedDataList;

	[Token(Token = "0x400DAEB")]
	[FieldOffset(Offset = "0x50")]
	private PNDELHDACMC m_CurrentSelctedColorType;

	[Token(Token = "0x400DAEC")]
	[FieldOffset(Offset = "0x54")]
	private Color mColor;

	[Token(Token = "0x400DAED")]
	[FieldOffset(Offset = "0x64")]
	private GameObject mLastPresetGo;

	[Token(Token = "0x400DAEE")]
	[FieldOffset(Offset = "0x68")]
	private Color[] mOriColor;

	[Token(Token = "0x400DAEF")]
	[FieldOffset(Offset = "0x6C")]
	private bool mHasEnter;

	[Token(Token = "0x400DAF0")]
	private const float m_HeightSpace = 40f;

	[Token(Token = "0x400DAF1")]
	[FieldOffset(Offset = "0x70")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x170010AE")]
	public Color CurrentColor
	{
		[Token(Token = "0x600C26C")]
		[Address(RVA = "0x1C4760C", Offset = "0x1C4760C", VA = "0x1C4760C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Color);
		}
		[Token(Token = "0x600C26D")]
		[Address(RVA = "0x1C47678", Offset = "0x1C47678", VA = "0x1C47678")]
		set
		{
		}
	}

	[Token(Token = "0x170010AF")]
	public float H
	{
		[Token(Token = "0x600C282")]
		[Address(RVA = "0x1C4B36C", Offset = "0x1C4B36C", VA = "0x1C4B36C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600C283")]
		[Address(RVA = "0x1C4B3C4", Offset = "0x1C4B3C4", VA = "0x1C4B3C4")]
		set
		{
		}
	}

	[Token(Token = "0x170010B0")]
	public float S
	{
		[Token(Token = "0x600C284")]
		[Address(RVA = "0x1C4B55C", Offset = "0x1C4B55C", VA = "0x1C4B55C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600C285")]
		[Address(RVA = "0x1C4B5B4", Offset = "0x1C4B5B4", VA = "0x1C4B5B4")]
		set
		{
		}
	}

	[Token(Token = "0x170010B1")]
	public float V
	{
		[Token(Token = "0x600C286")]
		[Address(RVA = "0x1C4B63C", Offset = "0x1C4B63C", VA = "0x1C4B63C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600C287")]
		[Address(RVA = "0x1C4B694", Offset = "0x1C4B694", VA = "0x1C4B694")]
		set
		{
		}
	}

	[Token(Token = "0x170010B2")]
	public float R
	{
		[Token(Token = "0x600C288")]
		[Address(RVA = "0x1C4B71C", Offset = "0x1C4B71C", VA = "0x1C4B71C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600C289")]
		[Address(RVA = "0x1C4B774", Offset = "0x1C4B774", VA = "0x1C4B774")]
		set
		{
		}
	}

	[Token(Token = "0x170010B3")]
	public float G
	{
		[Token(Token = "0x600C28A")]
		[Address(RVA = "0x1C4B7F4", Offset = "0x1C4B7F4", VA = "0x1C4B7F4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600C28B")]
		[Address(RVA = "0x1C4B84C", Offset = "0x1C4B84C", VA = "0x1C4B84C")]
		set
		{
		}
	}

	[Token(Token = "0x170010B4")]
	public float B
	{
		[Token(Token = "0x600C28C")]
		[Address(RVA = "0x1C4B8CC", Offset = "0x1C4B8CC", VA = "0x1C4B8CC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600C28D")]
		[Address(RVA = "0x1C4B924", Offset = "0x1C4B924", VA = "0x1C4B924")]
		set
		{
		}
	}

	[Token(Token = "0x170010B5")]
	private float A
	{
		[Token(Token = "0x600C28E")]
		[Address(RVA = "0x1C4B9A4", Offset = "0x1C4B9A4", VA = "0x1C4B9A4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600C28F")]
		[Address(RVA = "0x1C4B9FC", Offset = "0x1C4B9FC", VA = "0x1C4B9FC")]
		set
		{
		}
	}

	[Token(Token = "0x600C26B")]
	[Address(RVA = "0x1C474EC", Offset = "0x1C474EC", VA = "0x1C474EC")]
	public UIHudSceneEditActionAttributeColorPanelController()
	{
	}

	[Token(Token = "0x600C26E")]
	[Address(RVA = "0x1C47BF0", Offset = "0x1C47BF0", VA = "0x1C47BF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C26F")]
	[Address(RVA = "0x1C47C94", Offset = "0x1C47C94", VA = "0x1C47C94", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C270")]
	[Address(RVA = "0x1C48E70", Offset = "0x1C48E70", VA = "0x1C48E70")]
	public void RecordNotEnter()
	{
	}

	[Token(Token = "0x600C271")]
	[Address(RVA = "0x1C48ECC", Offset = "0x1C48ECC", VA = "0x1C48ECC")]
	private void OnPutDownSceneObject(object[] param)
	{
	}

	[Token(Token = "0x600C272")]
	[Address(RVA = "0x1C49380", Offset = "0x1C49380", VA = "0x1C49380")]
	private void OnCancelSceneObject(object[] param)
	{
	}

	[Token(Token = "0x600C273")]
	[Address(RVA = "0x1C47A98", Offset = "0x1C47A98", VA = "0x1C47A98")]
	private void SetCrossHairColor()
	{
	}

	[Token(Token = "0x600C274")]
	[Address(RVA = "0x1C495D8", Offset = "0x1C495D8", VA = "0x1C495D8")]
	private void RecoverPanelColor()
	{
	}

	[Token(Token = "0x600C275")]
	[Address(RVA = "0x1C496AC", Offset = "0x1C496AC", VA = "0x1C496AC")]
	private void ClockMaskClick()
	{
	}

	[Token(Token = "0x600C276")]
	[Address(RVA = "0x1C48404", Offset = "0x1C48404", VA = "0x1C48404")]
	private void InitPopMenus()
	{
	}

	[Token(Token = "0x600C277")]
	[Address(RVA = "0x1C49B30", Offset = "0x1C49B30", VA = "0x1C49B30")]
	private void AddSelectedData(PNDELHDACMC type)
	{
	}

	[Token(Token = "0x600C278")]
	[Address(RVA = "0x1C49908", Offset = "0x1C49908", VA = "0x1C49908")]
	private bool CanShadingColor(PNDELHDACMC type)
	{
		return default(bool);
	}

	[Token(Token = "0x600C279")]
	[Address(RVA = "0x1C49DCC", Offset = "0x1C49DCC", VA = "0x1C49DCC")]
	private void GenerateColorTypeSelectedMenuData()
	{
	}

	[Token(Token = "0x600C27A")]
	[Address(RVA = "0x1C4A1F4", Offset = "0x1C4A1F4", VA = "0x1C4A1F4")]
	private void OnColorTypeSelected(object obj)
	{
	}

	[Token(Token = "0x600C27B")]
	[Address(RVA = "0x1C4A40C", Offset = "0x1C4A40C", VA = "0x1C4A40C", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x600C27C")]
	[Address(RVA = "0x1C4A350", Offset = "0x1C4A350", VA = "0x1C4A350")]
	private void SetCurrentOriColor()
	{
	}

	[Token(Token = "0x600C27D")]
	[Address(RVA = "0x1C4A4A4", Offset = "0x1C4A4A4", VA = "0x1C4A4A4")]
	private void GetOriObjColor()
	{
	}

	[Token(Token = "0x600C27E")]
	[Address(RVA = "0x1C497D0", Offset = "0x1C497D0", VA = "0x1C497D0")]
	private void SetCrossHairColorActive(bool active)
	{
	}

	[Token(Token = "0x600C27F")]
	[Address(RVA = "0x1C4B284", Offset = "0x1C4B284", VA = "0x1C4B284", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600C280")]
	[Address(RVA = "0x1C49040", Offset = "0x1C49040", VA = "0x1C49040")]
	private void SaveColor()
	{
	}

	[Token(Token = "0x600C281")]
	[Address(RVA = "0x1C4B2F4", Offset = "0x1C4B2F4", VA = "0x1C4B2F4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C290")]
	[Address(RVA = "0x1C4BB40", Offset = "0x1C4BB40", VA = "0x1C4BB40")]
	public void SetCurrentColor(Color color)
	{
	}

	[Token(Token = "0x600C291")]
	[Address(RVA = "0x1C4BA84", Offset = "0x1C4BA84", VA = "0x1C4BA84")]
	private void OnAlphaChanged()
	{
	}

	[Token(Token = "0x600C292")]
	[Address(RVA = "0x1C4BBD8", Offset = "0x1C4BBD8", VA = "0x1C4BBD8")]
	private void OnSVTextureDrag(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x600C293")]
	[Address(RVA = "0x1C4BEE8", Offset = "0x1C4BEE8", VA = "0x1C4BEE8")]
	private void OnSVTexturePress(GameObject go, bool state)
	{
	}

	[Token(Token = "0x600C294")]
	[Address(RVA = "0x1C4BC5C", Offset = "0x1C4BC5C", VA = "0x1C4BC5C")]
	private void OnSVTextureDragOrPress()
	{
	}

	[Token(Token = "0x600C295")]
	[Address(RVA = "0x1C47748", Offset = "0x1C47748", VA = "0x1C47748")]
	private void RGBChanged()
	{
	}

	[Token(Token = "0x600C296")]
	[Address(RVA = "0x1C4B44C", Offset = "0x1C4B44C", VA = "0x1C4B44C")]
	private void HSVChanged()
	{
	}

	[Token(Token = "0x600C297")]
	[Address(RVA = "0x1C4BF74", Offset = "0x1C4BF74", VA = "0x1C4BF74")]
	private void OnAlphaSliderBar()
	{
	}

	[Token(Token = "0x600C298")]
	[Address(RVA = "0x1C4C00C", Offset = "0x1C4C00C", VA = "0x1C4C00C")]
	private void OnClickClearPresetBtn()
	{
	}

	[Token(Token = "0x600C299")]
	[Address(RVA = "0x1C4C0D0", Offset = "0x1C4C0D0", VA = "0x1C4C0D0")]
	private void OnHSVSliderBar()
	{
	}

	[Token(Token = "0x600C29A")]
	[Address(RVA = "0x1C486AC", Offset = "0x1C486AC", VA = "0x1C486AC")]
	private void GenerateHueBar()
	{
	}

	[Token(Token = "0x600C29B")]
	[Address(RVA = "0x1C48BD4", Offset = "0x1C48BD4", VA = "0x1C48BD4")]
	private void GenerateAlphaTexture()
	{
	}

	[Token(Token = "0x600C29C")]
	[Address(RVA = "0x1C48928", Offset = "0x1C48928", VA = "0x1C48928")]
	private void GenerateSVTexture()
	{
	}

	[Token(Token = "0x600C29D")]
	[Address(RVA = "0x1C4A7A0", Offset = "0x1C4A7A0", VA = "0x1C4A7A0")]
	private void LoadLatestColor()
	{
	}

	[Token(Token = "0x600C29E")]
	[Address(RVA = "0x1C4C3FC", Offset = "0x1C4C3FC", VA = "0x1C4C3FC")]
	private void OnColorPresetClick(Color c)
	{
	}

	[Token(Token = "0x600C29F")]
	[Address(RVA = "0x1C4C494", Offset = "0x1C4C494", VA = "0x1C4C494")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C2A0")]
	[Address(RVA = "0x1C4C49C", Offset = "0x1C4C49C", VA = "0x1C4C49C")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x600C2A1")]
	[Address(RVA = "0x1C4C4A4", Offset = "0x1C4C4A4", VA = "0x1C4C4A4")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	[Token(Token = "0x600C2A2")]
	[Address(RVA = "0x1C4C4AC", Offset = "0x1C4C4AC", VA = "0x1C4C4AC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
