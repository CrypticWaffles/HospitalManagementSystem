using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace HospitalManager
{
    [Serializable]
    public class User
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string UserID { get; set; }
        [BsonElement("username"), BsonRepresentation(BsonType.String)]
        public string Username { get; set; }
        [BsonElement("password"), BsonRepresentation(BsonType.String)]
        public string Password { get; set; }
        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public string Email { get; set; }
        [BsonElement("role"), BsonRepresentation(BsonType.String)]
        public string Role { get; set; }
        [BsonElement("registered"), BsonRepresentation(BsonType.Boolean)]
        public bool Registered { get; set; }
        [BsonElement("patientID"), BsonRepresentation(BsonType.Int32)]
        public int PatientID { get; set; }
    }
}