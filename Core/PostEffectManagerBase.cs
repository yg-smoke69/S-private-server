using System;
using System.Collections.Generic;
using AmplifyColor;
using COW.Graphics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B00")]
public class PostEffectManagerBase : MonoBehaviour
{
	[Token(Token = "0x40191DE")]
	public const int LutSize = 32;

	[Token(Token = "0x40191DF")]
	public const int LutWidth = 1024;

	[Token(Token = "0x40191E0")]
	public const int LutHeight = 32;

	[Token(Token = "0x40191E1")]
	private const int DepthCurveLutRange = 1024;

	[Token(Token = "0x40191E2")]
	[FieldOffset(Offset = "0xC")]
	public List<Camera> extraCameras;

	[Token(Token = "0x40191E3")]
	[FieldOffset(Offset = "0x10")]
	private PostEffectProfile m_profile;

	[Token(Token = "0x40191E4")]
	[FieldOffset(Offset = "0x14")]
	private Camera ownerCamera;

	[Token(Token = "0x40191E5")]
	[FieldOffset(Offset = "0x18")]
	private Texture2D defaultLut;

	[Token(Token = "0x40191E6")]
	[FieldOffset(Offset = "0x1C")]
	public FNPGLMEKKJB[] customEffect;

	[Token(Token = "0x40191E7")]
	[FieldOffset(Offset = "0x20")]
	private int enableEffectCount;

	[Token(Token = "0x40191E8")]
	[FieldOffset(Offset = "0x24")]
	private float m_cameraDepth;

	[NonSerialized]
	[Token(Token = "0x40191E9")]
	[FieldOffset(Offset = "0x28")]
	public float blendAmount;

	[Token(Token = "0x40191EA")]
	[FieldOffset(Offset = "0x2C")]
	private RenderTexture m_colorRT;

	[Token(Token = "0x40191EB")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture m_depthRT;

	[Token(Token = "0x40191EC")]
	[FieldOffset(Offset = "0x34")]
	private string m_depthRTName;

	[Token(Token = "0x40191ED")]
	[FieldOffset(Offset = "0x38")]
	private RenderTexture m_activeRT;

	[Token(Token = "0x40191EE")]
	[FieldOffset(Offset = "0x3C")]
	private RenderTexture m_replacementRT;

	[Token(Token = "0x40191EF")]
	[FieldOffset(Offset = "0x40")]
	private AmplifyColorTriggerProxyBase actualTriggerProxy;

	[Token(Token = "0x40191F0")]
	[FieldOffset(Offset = "0x44")]
	public VolumeEffectFlags EffectFlags;

	[Token(Token = "0x40191F1")]
	[FieldOffset(Offset = "0x48")]
	private string sharedInstanceID;

	[Token(Token = "0x40191F2")]
	[FieldOffset(Offset = "0x4C")]
	private bool silentError;

	[Token(Token = "0x40191F3")]
	[FieldOffset(Offset = "0x4D")]
	private bool isInit;

	[Token(Token = "0x40191F4")]
	[FieldOffset(Offset = "0x50")]
	private int m_RTWidth;

	[Token(Token = "0x40191F5")]
	[FieldOffset(Offset = "0x54")]
	private int m_RTHeight;

	[NonSerialized]
	[Token(Token = "0x40191F6")]
	[FieldOffset(Offset = "0x58")]
	public int RTWidth;

	[NonSerialized]
	[Token(Token = "0x40191F7")]
	[FieldOffset(Offset = "0x5C")]
	public int RTHeight;

	[NonSerialized]
	[Token(Token = "0x40191F8")]
	[FieldOffset(Offset = "0x60")]
	public bool isLinear;

	[Token(Token = "0x40191F9")]
	[FieldOffset(Offset = "0x64")]
	private int m_enableMask;

	[Token(Token = "0x170017C3")]
	public PostEffectProfile Profile
	{
		[Token(Token = "0x6017693")]
		[Address(RVA = "0x1E243D8", Offset = "0x1E243D8", VA = "0x1E243D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017692")]
		[Address(RVA = "0x1E24220", Offset = "0x1E24220", VA = "0x1E24220")]
		set
		{
		}
	}

	[Token(Token = "0x170017C4")]
	public Texture2D DefaultLut
	{
		[Token(Token = "0x6017694")]
		[Address(RVA = "0x1E243E0", Offset = "0x1E243E0", VA = "0x1E243E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C5")]
	public string SharedInstanceID
	{
		[Token(Token = "0x6017695")]
		[Address(RVA = "0x1E24774", Offset = "0x1E24774", VA = "0x1E24774")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C6")]
	public RenderTexture ReplacementRT
	{
		[Token(Token = "0x6017696")]
		[Address(RVA = "0x1E2477C", Offset = "0x1E2477C", VA = "0x1E2477C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017697")]
		[Address(RVA = "0x1E24818", Offset = "0x1E24818", VA = "0x1E24818")]
		set
		{
		}
	}

	[Token(Token = "0x170017C7")]
	public Camera OwnerCamera
	{
		[Token(Token = "0x6017698")]
		[Address(RVA = "0x1E248B0", Offset = "0x1E248B0", VA = "0x1E248B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017691")]
	[Address(RVA = "0x1E240DC", Offset = "0x1E240DC", VA = "0x1E240DC")]
	public PostEffectManagerBase()
	{
	}

	[Token(Token = "0x6017699")]
	[Address(RVA = "0x1E248B8", Offset = "0x1E248B8", VA = "0x1E248B8")]
	public void NewSharedInstanceID()
	{
	}

	[Token(Token = "0x601769A")]
	[Address(RVA = "0x1E2496C", Offset = "0x1E2496C", VA = "0x1E2496C")]
	private void ReportNotSupported()
	{
	}

	[Token(Token = "0x601769B")]
	[Address(RVA = "0x1E24A0C", Offset = "0x1E24A0C", VA = "0x1E24A0C")]
	private bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x601769C")]
	[Address(RVA = "0x1E24A40", Offset = "0x1E24A40", VA = "0x1E24A40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x601769D")]
	[Address(RVA = "0x1E25F90", Offset = "0x1E25F90", VA = "0x1E25F90")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x601769E")]
	[Address(RVA = "0x1E26140", Offset = "0x1E26140", VA = "0x1E26140")]
	private void Cleanup()
	{
	}

	[Token(Token = "0x601769F")]
	[Address(RVA = "0x1E25748", Offset = "0x1E25748", VA = "0x1E25748")]
	private void CheckCamera()
	{
	}

	[Token(Token = "0x60176A0")]
	[Address(RVA = "0x1E24F48", Offset = "0x1E24F48", VA = "0x1E24F48")]
	private void Init()
	{
	}

	[Token(Token = "0x60176A1")]
	[Address(RVA = "0x1E26844", Offset = "0x1E26844", VA = "0x1E26844")]
	private void Start()
	{
	}

	[Token(Token = "0x60176A2")]
	[Address(RVA = "0x1E269A8", Offset = "0x1E269A8", VA = "0x1E269A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60176A3")]
	[Address(RVA = "0x1E26FA8", Offset = "0x1E26FA8", VA = "0x1E26FA8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60176A4")]
	[Address(RVA = "0x1E264CC", Offset = "0x1E264CC", VA = "0x1E264CC")]
	private void UpdateEnableState()
	{
	}

	[Token(Token = "0x60176A5")]
	[Address(RVA = "0x1E24480", Offset = "0x1E24480", VA = "0x1E24480")]
	private Texture2D CreateDefaultLut()
	{
		return null;
	}

	[Token(Token = "0x60176A6")]
	[Address(RVA = "0x1E27540", Offset = "0x1E27540", VA = "0x1E27540")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x60176A7")]
	[Address(RVA = "0x1E278F4", Offset = "0x1E278F4", VA = "0x1E278F4")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60176A8")]
	[Address(RVA = "0x1E28008", Offset = "0x1E28008", VA = "0x1E28008")]
	public void SetCameraDepth(int depth)
	{
	}

	[Token(Token = "0x60176A9")]
	[Address(RVA = "0x1E28018", Offset = "0x1E28018", VA = "0x1E28018")]
	public void ResetCameraDepth()
	{
	}

	[Token(Token = "0x60176AA")]
	[Address(RVA = "0x1E242C4", Offset = "0x1E242C4", VA = "0x1E242C4")]
	private void RefreshData(object[] data)
	{
	}

	[Token(Token = "0x60176AB")]
	[Address(RVA = "0x1E27104", Offset = "0x1E27104", VA = "0x1E27104")]
	private int ValidateEnable(int mask)
	{
		return default(int);
	}

	[Token(Token = "0x60176AC")]
	[Address(RVA = "0x1E27448", Offset = "0x1E27448", VA = "0x1E27448")]
	public bool IsEffectEnable(EffectType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60176AD")]
	[Address(RVA = "0x1E26EEC", Offset = "0x1E26EEC", VA = "0x1E26EEC")]
	private bool NeedUseDepth()
	{
		return default(bool);
	}

	[Token(Token = "0x60176AE")]
	[Address(RVA = "0x1E25810", Offset = "0x1E25810", VA = "0x1E25810")]
	private void CheckRenderTexture()
	{
	}

	[Token(Token = "0x60176AF")]
	[Address(RVA = "0x1E280E0", Offset = "0x1E280E0", VA = "0x1E280E0")]
	public void SetEnable(EffectType type, bool enable)
	{
	}
}
