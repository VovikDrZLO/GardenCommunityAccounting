using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GardenCommunityAccounting.Models
{
    public class Land
    {
        [Key]
        public Guid Id { get; set; }
        public int Number { get; set; }
        public Guid? OwnerId { get; set; }
        public Person Owner { get; set; }
        public bool IsPrivate { get; set; }
    }
    public class LandToPerson
    {
        [Key]
        public Guid Id { get; set; }
        public Guid LandId { get; set; }
        public Land Land { get; set; }
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }

    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool IsCommunityMember { get; set; }
    }

    public class IncomeDocument :IDocumentModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Number { get; set; }
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public Guid DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
        public DateTime Date { get; set; }
    }

    public class ElectricBill : IncomeDocument
    {
        public int LastPayedCounterValue { get; set; }
        public int CurrentCounterValue { get; set; }
        public int Diff { get; set; }
    }

    public class SpecialPay : IncomeDocument
    {
        public Guid SpecialPayTypeId { get; set; }
        public SpecialPayType SpecialPayType { get; set; }
    }

    public class LandTax : IncomeDocument
    {

    }

    public class OutcomeDocument :IDocumentModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Number { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string Description { get; set; }
        [Required]
        public Guid DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
        public DateTime Date { get; set; }
    }

    public class Counter
    {
        [Key]
        public Guid Id { get; set; }
        public int LastValue { get; set; }
        public string Name { get; set; }
        
    }    

    public class CounterValue
    {
        [Key]
        public Guid Id { get; set; }
        public int Value { get; set; }
        public Guid CounterId { get; set; }
        public Counter Counter { get; set; }
        public DateTime DateOfValue { get; set; }
    }    
    public class LandToPublicCounter
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PublicCounterId { get; set; }
        public Counter PublicCounter { get; set; }
        public Guid LandId { get; set; }
        public Land Land { get; set; }
    }
}
