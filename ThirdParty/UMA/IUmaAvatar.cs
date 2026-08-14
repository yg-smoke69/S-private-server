using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMACharacterSystem;

namespace UMA;

[Token(Token = "0x2003C70")]
public interface IUmaAvatar : _Attribute, IConvertible
{
	[Token(Token = "0x601820E")]
	void SetForceChangeRace();

	[Token(Token = "0x601820F")]
	void ChangeRace(string racename, ChangeRaceOptions customChangeRaceOptions = ChangeRaceOptions.useDefaults);

	[Token(Token = "0x6018210")]
	void SetColor(string Name, OverlayColorData colorData, bool UpdateTexture = true);

	[Token(Token = "0x6018211")]
	void ForceUpdateColor();

	[Token(Token = "0x6018212")]
	void BuildCharacterImmediatly();

	[Token(Token = "0x6018213")]
	void BuildCharacter();

	[Token(Token = "0x6018214")]
	void ForceUpdate(bool DnaDirty, bool TextureDirty = false, bool MeshDirty = false);

	[Token(Token = "0x6018215")]
	void InitAsyncLoading(bool pre);

	[Token(Token = "0x6018216")]
	bool IsAsyncLoading();
}
