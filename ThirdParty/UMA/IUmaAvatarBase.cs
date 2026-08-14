using Il2CppDummyDll;
using UMA.Simple;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003C6D")]
public interface IUmaAvatarBase
{
	[Token(Token = "0x17001997")]
	UMAData UmaData
	{
		[Token(Token = "0x60181F8")]
		get;
	}

	[Token(Token = "0x60181F7")]
	GameObject GetGameObject();

	[Token(Token = "0x60181F9")]
	void SetEnableMipMap(bool enableMipMap);

	[Token(Token = "0x60181FA")]
	void SetEnableRenderTexturePool(bool flag);

	[Token(Token = "0x60181FB")]
	void SetTextureScaleFactor(int scale);

	[Token(Token = "0x60181FC")]
	void SetNormalSpecTexScale(float scale);

	[Token(Token = "0x60181FD")]
	void SetUpdateWhenOffSceen(bool flag);

	[Token(Token = "0x60181FE")]
	void SetNeedGenerateMesh(bool needMesh);

	[Token(Token = "0x60181FF")]
	void SetUsingRGB565(bool use);

	[Token(Token = "0x6018200")]
	void SetAtlasResolutionScale(float scale);

	[Token(Token = "0x6018201")]
	void SetNoMergeTexture(bool noMerge);

	[Token(Token = "0x6018202")]
	void EnableDebugLog(bool enable);

	[Token(Token = "0x6018203")]
	void SetVisible(bool visible);

	[Token(Token = "0x6018204")]
	UMAContextIndividual UseIndividualContextCache(SlotOverlayAssetCache cache);
}
