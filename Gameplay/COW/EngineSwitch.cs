using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000285")]
public enum EngineSwitch
{
	[Token(Token = "0x4000F57")]
	Unknown = 0,
	[Token(Token = "0x4000F58")]
	UnloadAllEmbeddedSceneObjects = 1,
	[Token(Token = "0x4000F59")]
	EnableLODShader = 2,
	[Token(Token = "0x4000F5A")]
	EnableSmallSerializedFileExternals = 4,
	[Token(Token = "0x4000F5B")]
	EnableShaderVariantCount = 8,
	[Token(Token = "0x4000F5C")]
	EnableShaderKeywordStrip = 0x10,
	[Token(Token = "0x4000F5D")]
	EnableShaderRuntimeReload = 0x20,
	[Token(Token = "0x4000F5E")]
	EnableParticleMemOpt = 0x40,
	[Token(Token = "0x4000F5F")]
	FileCacherReadLazyMalloc = 0x80,
	[Token(Token = "0x4000F60")]
	EnableSkinnedCompress = 0x100,
	[Token(Token = "0x4000F61")]
	ClostNegScaleColliderWarning = 0x200,
	[Token(Token = "0x4000F62")]
	EnableAndroidBlit = 0x400,
	[Token(Token = "0x4000F63")]
	EnableShaderKeywordStripAllLOD = 0x800,
	[Token(Token = "0x4000F64")]
	EnableShaderStripAB = 0x1000,
	[Token(Token = "0x4000F65")]
	EnableShaderRecordMaterials = 0x2000,
	[Token(Token = "0x4000F66")]
	EnableShaderStripAllLOD = 0x4000,
	[Token(Token = "0x4000F67")]
	EnableShaderKeywordStripFallBack = 0x8000,
	[Token(Token = "0x4000F68")]
	EnableShaderKeywordStripBRNight = 0x10000,
	[Token(Token = "0x4000F69")]
	EnableShaderForceUseAPK = 0x20000,
	[Token(Token = "0x4000F6A")]
	EnableRecordABPath = 0x40000
}
