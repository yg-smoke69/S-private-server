using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200041C")]
public interface MPICKNDAPEB
{
	[Token(Token = "0x6001436")]
	Vector3 GetCameraTrackableEntityPosition();

	[Token(Token = "0x6001437")]
	Vector3 GetCameraTrackableEntityTopPosition();

	[Token(Token = "0x6001438")]
	Quaternion GetCameraTrackableEntityAimRotation();

	[Token(Token = "0x6001439")]
	Transform GetCameraTrackableEntityTransfrom();

	[Token(Token = "0x600143A")]
	bool IsCameraTrackableEntityAlive();
}
