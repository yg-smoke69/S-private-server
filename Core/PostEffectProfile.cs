using AmplifyColor;
using COW.Graphics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B01")]
public sealed class PostEffectProfile : ScriptableObject
{
	[Token(Token = "0x40191FA")]
	[FieldOffset(Offset = "0xC")]
	public int lowestMask;

	[Token(Token = "0x40191FB")]
	[FieldOffset(Offset = "0x10")]
	public int lowMask;

	[Token(Token = "0x40191FC")]
	[FieldOffset(Offset = "0x14")]
	public int ultraMask;

	[Token(Token = "0x40191FD")]
	[FieldOffset(Offset = "0x18")]
	public bool depthBlurEnable;

	[Token(Token = "0x40191FE")]
	[FieldOffset(Offset = "0x19")]
	public bool useImageDepthBlur;

	[Token(Token = "0x40191FF")]
	[FieldOffset(Offset = "0x1C")]
	public float depthBlurStrength;

	[Token(Token = "0x4019200")]
	[FieldOffset(Offset = "0x20")]
	public bool bloomEnable;

	[Token(Token = "0x4019201")]
	[FieldOffset(Offset = "0x24")]
	public float ultraIntensity;

	[Token(Token = "0x4019202")]
	[FieldOffset(Offset = "0x28")]
	public float ultraThreshold;

	[Token(Token = "0x4019203")]
	[FieldOffset(Offset = "0x2C")]
	public float ultraSoftKnee;

	[Token(Token = "0x4019204")]
	[FieldOffset(Offset = "0x30")]
	public float ultraDiffusion;

	[Token(Token = "0x4019205")]
	[FieldOffset(Offset = "0x34")]
	public Color BloomColor;

	[Token(Token = "0x4019206")]
	[FieldOffset(Offset = "0x44")]
	public bool colorGradingEnable;

	[Token(Token = "0x4019207")]
	[FieldOffset(Offset = "0x48")]
	public Quality QualityLevel;

	[Token(Token = "0x4019208")]
	[FieldOffset(Offset = "0x4C")]
	public Texture LutTexture;

	[Token(Token = "0x4019209")]
	[FieldOffset(Offset = "0x50")]
	public bool UseAvatarLut;

	[Token(Token = "0x401920A")]
	[FieldOffset(Offset = "0x54")]
	public Texture LutAvatarTexture;

	[Token(Token = "0x401920B")]
	[FieldOffset(Offset = "0x58")]
	public float GlitchOffsetValue;

	[Token(Token = "0x401920C")]
	[FieldOffset(Offset = "0x5C")]
	public Color GlitchColor;

	[Token(Token = "0x401920D")]
	[FieldOffset(Offset = "0x6C")]
	public Texture GlitchTexture;

	[Token(Token = "0x401920E")]
	[FieldOffset(Offset = "0x70")]
	public float ScreenEffectValue;

	[Token(Token = "0x401920F")]
	[FieldOffset(Offset = "0x74")]
	public Color ScreenEffectColor;

	[Token(Token = "0x4019210")]
	[FieldOffset(Offset = "0x84")]
	public Texture ScreenEffectTexture;

	[Token(Token = "0x4019211")]
	[FieldOffset(Offset = "0x88")]
	public float ColorFade;

	[Token(Token = "0x4019212")]
	[FieldOffset(Offset = "0x8C")]
	public bool ACESEnable;

	[Token(Token = "0x4019213")]
	[FieldOffset(Offset = "0x90")]
	public IHDOEPCAGJA.HMEBLIODHEO ACESType;

	[Token(Token = "0x4019214")]
	[FieldOffset(Offset = "0x94")]
	public Texture AcesLutTexture;

	[Token(Token = "0x4019215")]
	[FieldOffset(Offset = "0x98")]
	public Texture LegacyLutTexture;

	[Token(Token = "0x4019216")]
	[FieldOffset(Offset = "0x9C")]
	public bool BRRimEnable;

	[Token(Token = "0x4019217")]
	[FieldOffset(Offset = "0xA0")]
	public Color RimColor;

	[Token(Token = "0x4019218")]
	[FieldOffset(Offset = "0xB0")]
	public bool FogEnable;

	[Token(Token = "0x4019219")]
	[FieldOffset(Offset = "0xB4")]
	public Color FogColorStart;

	[Token(Token = "0x401921A")]
	[FieldOffset(Offset = "0xC4")]
	public Color FogColorEnd;

	[Token(Token = "0x401921B")]
	[FieldOffset(Offset = "0xD4")]
	public Vector4 FogParam0;

	[Token(Token = "0x401921C")]
	[FieldOffset(Offset = "0xE4")]
	public Vector4 FogParam1;

	[Token(Token = "0x401921D")]
	[FieldOffset(Offset = "0xF4")]
	public Vector4 FogParam2;

	[Token(Token = "0x401921E")]
	[FieldOffset(Offset = "0x104")]
	public Vector4 FogParam3;

	[Token(Token = "0x401921F")]
	[FieldOffset(Offset = "0x114")]
	public Color DirectionFogColor;

	[Token(Token = "0x4019220")]
	[FieldOffset(Offset = "0x124")]
	public Vector4 DirectionFogDir;

	[Token(Token = "0x4019221")]
	[FieldOffset(Offset = "0x134")]
	public bool LinearToGammaEnable;

	[Token(Token = "0x4019222")]
	[FieldOffset(Offset = "0x135")]
	public bool FastAOEnable;

	[Token(Token = "0x4019223")]
	[FieldOffset(Offset = "0x138")]
	public float intensity;

	[Token(Token = "0x4019224")]
	[FieldOffset(Offset = "0x13C")]
	public float blurAmount;

	[Token(Token = "0x4019225")]
	[FieldOffset(Offset = "0x140")]
	public float radius;

	[Token(Token = "0x4019226")]
	[FieldOffset(Offset = "0x144")]
	public float area;

	[Token(Token = "0x4019227")]
	[FieldOffset(Offset = "0x148")]
	public bool fastMode;

	[Token(Token = "0x4019228")]
	[FieldOffset(Offset = "0x14C")]
	public float diffThreshold;

	[Token(Token = "0x4019229")]
	[FieldOffset(Offset = "0x150")]
	public Vector4 sampleData1;

	[Token(Token = "0x401922A")]
	[FieldOffset(Offset = "0x160")]
	public Vector4 sampleData2;

	[Token(Token = "0x401922B")]
	[FieldOffset(Offset = "0x170")]
	public Vector3 rayRotDegrees;

	[Token(Token = "0x401922C")]
	[FieldOffset(Offset = "0x17C")]
	public bool HDREnable;

	[Token(Token = "0x401922D")]
	[FieldOffset(Offset = "0x180")]
	public float HDRTonemapExp;

	[Token(Token = "0x401922E")]
	[FieldOffset(Offset = "0x184")]
	public bool FXAAEnable;

	[Token(Token = "0x401922F")]
	[FieldOffset(Offset = "0x185")]
	public bool OutlineEnable;

	[Token(Token = "0x4019230")]
	[FieldOffset(Offset = "0x188")]
	public float farClipPlane;

	[Token(Token = "0x4019231")]
	[FieldOffset(Offset = "0x18C")]
	public float width;

	[Token(Token = "0x4019232")]
	[FieldOffset(Offset = "0x190")]
	public float brightness;

	[Token(Token = "0x4019233")]
	[FieldOffset(Offset = "0x194")]
	public float brightnessWidth;

	[Token(Token = "0x4019234")]
	[FieldOffset(Offset = "0x198")]
	public int blurIterations;

	[Token(Token = "0x60176B0")]
	[Address(RVA = "0x1E282D8", Offset = "0x1E282D8", VA = "0x1E282D8")]
	public PostEffectProfile()
	{
	}
}
