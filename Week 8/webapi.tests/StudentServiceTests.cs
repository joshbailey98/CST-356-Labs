using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;

public class StudentServiceTests
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock
    private const string SpecialKey = "j";

    [SetUp]
    public void Setup()
    {
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void ShouldNotReturnSpecialStudents()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 1,
                    EmailAddress = "bill@gmail.com"
                },
                new Student {
                    StudentId = 2,
                    EmailAddress = "tom@gmail.com"
                }
            }
        );

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(studentViewModels.Any(pdto => pdto.Special), Is.EqualTo(false));

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(pdto => pdto.Special).Should().BeFalse();
    }

    [Test]
    public void ShouldReturnSpecialStudents()
    {
        // Arrange
        var expectedStudentEmail = "jill@gmail.com";

        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 1,
                    EmailAddress = expectedStudentEmail
                },
                new Student {
                    StudentId = 2,
                    EmailAddress = "tom@gmail.com"
                }
            }
        );

        // Act
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (FluentAssertions)
        studentViewModels.Count(pdto => pdto.Special).Should().Be(1);
        studentViewModels.Single(pdto => pdto.Special).EmailAddress.Should().Be(expectedStudentEmail);
    }
}