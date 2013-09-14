/*
Navicat MySQL Data Transfer

Source Server         : mysql
Source Server Version : 50532
Source Host           : localhost:3306
Source Database       : expertadvisors

Target Server Type    : MYSQL
Target Server Version : 50532
File Encoding         : 65001

Date: 2013-09-07 21:24:08
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `linebalanceadvisordetails`
-- ----------------------------
DROP TABLE IF EXISTS `linebalanceadvisordetails`;
CREATE TABLE `linebalanceadvisordetails` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Pair` varchar(255) NOT NULL,
  `TimeFrame` int(11) NOT NULL,
  `CreatedOn` datetime NOT NULL,
  `State` int(11) NOT NULL,
  `UpdatedBalance` double(10,0) DEFAULT '0.0',
  `CurrentBalance` double(10,0) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of linebalanceadvisordetails
-- ----------------------------
