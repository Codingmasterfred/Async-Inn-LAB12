# Async-Inn-LAB12
fredrick 
8/2/2023
    
[HotelLocation]
- LocationId (PK)
- Name
- City
- State
- Address
- Phone_number

[RoomLayout]
- LayoutId (PK)
- Name
- Description

[RoomAmenity]
- AmenityType (Enum, Values: air conditioning, coffee maker, ocean view, mini bar, ...)

[Room]
- LocationId (PK, FK)
- RoomNumber (PK)
- LayoutId (FK)
- AmenityType (FK)
- Nickname
- IsPetFriendly
- Price
